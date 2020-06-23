use QuanLyKhoHang
go


--trigger khi xoá phiếu xuất thì tất cả chi tiết phiếu xuất cũng xoá theo
create trigger XOA on phieu_xuat
instead of delete as
begin
	delete from chi_tiet_phieu_xuat where phieu_xuat_id in ( select id from deleted);
	delete from phieu_xuat where id int(select id from deleted);
end

--trigger update số lượng khi tạo pnhap
create trigger Update_SLTon_nhap on chi_tiet_phieu_nhap
INSTEAD OF INSERT
as begin
	declare @slMoi int
	set @slMoi = (select so_luong from inserted)													
	insert into chi_tiet_phieu_nhap(phieu_nhap_id,mat_hang_id,so_luong,don_gia,don_vi)
	select * from inserted
	update mat_hang
	set remain=remain+@slMoi
	where id in (select mat_hang_id from inserted)
end
--trigger update số lượng khi sửa pnhap
create trigger Update_SLTon_nhap1 on chi_tiet_phieu_nhap
INSTEAD OF update
as begin
	declare @slMoi int
	set @slMoi = (select so_luong from inserted)
	declare @slCu int
	set @slCu = (select so_luong from chi_tiet_phieu_nhap 
				where phieu_nhap_id in (select phieu_nhap_id from inserted) and
				mat_hang_id in (select mat_hang_id from inserted))													
	update chi_tiet_phieu_nhap
	set chi_tiet_phieu_nhap.mat_hang_id = ins.mat_hang_id, 
		chi_tiet_phieu_nhap.so_luong = ins.so_luong,
		chi_tiet_phieu_nhap.don_gia = ins.don_gia,
		chi_tiet_phieu_nhap.don_vi = ins.don_vi
	 FROM chi_tiet_phieu_nhap,inserted AS ins
	 where chi_tiet_phieu_nhap.phieu_nhap_id = ins.phieu_nhap_id and 
		chi_tiet_phieu_nhap.mat_hang_id = ins.mat_hang_id

	update mat_hang
	set remain=remain - @slCu + @slMoi
	where id in (select mat_hang_id from inserted)
end


--trigger update số lượng khi tạo pxuat
create trigger Update_SLTon_xuat on chi_tiet_phieu_xuat
INSTEAD OF INSERT
as begin
	declare @slMoi int
	set @slMoi = (select so_luong from inserted)													
	insert into chi_tiet_phieu_xuat(phieu_xuat_id,mat_hang_id,so_luong)
	select * from inserted
	update mat_hang
	set remain=remain-@slMoi
	where id in (select mat_hang_id from inserted)
end
--trigger update số lượng khi sửa pnhap
create trigger Update_SLTon_xuat1 on chi_tiet_phieu_xuat
INSTEAD OF update
as begin
	declare @slMoi int
	set @slMoi = (select so_luong from inserted)
	declare @slCu int
	set @slCu = (select so_luong from chi_tiet_phieu_xuat
				where phieu_xuat_id in (select phieu_xuat_id from inserted) and
				mat_hang_id in (select mat_hang_id from inserted))													
	update chi_tiet_phieu_xuat
	set chi_tiet_phieu_xuat.mat_hang_id = ins.mat_hang_id, 
		chi_tiet_phieu_xuat.so_luong = ins.so_luong
	 FROM chi_tiet_phieu_xuat,inserted AS ins
	 where chi_tiet_phieu_xuat.phieu_xuat_id = ins.phieu_xuat_id and 
		chi_tiet_phieu_xuat.mat_hang_id = ins.mat_hang_id

	update mat_hang
	set remain=remain + @slCu - @slMoi
	where id in (select mat_hang_id from inserted)
end


---------------------------------
--trigger xóa phiếu nhập + ncc
CREATE TRIGGER XOA ON nha_cung_cap
INSTEAD OF DELETE AS
BEGIN 
DELETE FROM chi_tiet_phieu_nhap WHERE phieu_nhap_id IN (SELECT phieu_nhap.id
FROM phieu_nhap WHERE phieu_nhap.ncc_id IN (SELECT deleted.id FROM deleted));
DELETE FROM phieu_nhap WHERE phieu_nhap.ncc_id IN(SELECT deleted.id FROM deleted);
DELETE FROM nha_cung_cap WHERE nha_cung_cap.id IN (SELECT deleted.id FROM deleted);
END
----------
GO
CREATE TRIGGER XOA1 ON phieu_nhap
INSTEAD OF DELETE AS
BEGIN
DELETE FROM chi_tiet_phieu_nhap WHERE phieu_nhap_id IN (SELECT id
FROM deleted );
DELETE FROM phieu_nhap WHERE phieu_nhap.id IN(SELECT id FROM deleted);
END

-------------------------------------------------------

create proc ChiPhiNhapTheoQuy
	@nam int
as begin
	declare @table_temp TABLE(
		id int not null
	);
	insert into @table_temp
	select id from phieu_nhap where DATEPART(YEAR,ngay_nhap) = @nam
	declare @table_quy TABLE (
    Quy INT NOT NULL,
    id INT NOT NULL
	);
	insert into @table_quy
	select  DATEPART(quarter,ngay_nhap) as Quy, id from phieu_nhap
	where id in (select * from @table_temp)
	declare @table_tien TABLE (
    phieu_nhap_id INT NOT NULL,
    Tien INT NOT NULL
	);
	insert into @table_tien
	select phieu_nhap_id,sum(don_gia*so_luong)as tien from chi_tiet_phieu_nhap 
		where phieu_nhap_id in (select * from @table_temp)
		group by phieu_nhap_id
	declare @table_fn TABLE (
	id INT NOT NULL,
    Quy INT NOT NULL,
    Tien INT NOT NULL
	);
	insert into @table_fn
	select id,Quy,Tien from @table_quy,@table_tien where phieu_nhap_id = id
	

	select Quy, Sum(Tien) as tongtien from @table_fn group by Quy
end


------------------------------------------------

create proc ThongKePhieuTheoThang
	@nam int
as begin
	declare @table_pn TABLE (
	id INT  NULL,
    Thang INT NOT NULL
	);
	insert into @table_pn
	select id,DATEPART(month,ngay_nhap)as t from phieu_nhap where DATEPART(year,ngay_nhap) = @nam
	declare @table_px TABLE (
	id INT NULL,
    Thang INT NOT NULL
	);
	insert into @table_px
	select id,DATEPART(month,ngay_xuat)as t from phieu_xuat where DATEPART(year,ngay_xuat) = @nam 
	declare @table_th TABLE (
	nhap INT NULL,
    Thang INT NOT NULL,
	xuat INT NULL
	);
	declare @t int = 1
	while (@t < 13)
	begin
		declare @pn int
		set @pn = (select count(id) from @table_pn where Thang = @t group by Thang) 
		if @pn is null set @pn =0
		declare @px int
		set @px = (select count(id) from @table_px where Thang = @t group by Thang)
		if @px is null set @px =0
		insert into @table_th values (@pn,@t,@px)
		set @t = @t+1;
	end
	
	select * from @table_th
end
----------------------------------------------------------------------------------------
create proc [dbo].[SuaNV]
@id int,@ten nvarchar(100),@tuoi int,@sex bit,@dia_chi nvarchar(50),@luong int,@sdt varchar(50)
as begin 
update nhan_vien
set ten=@ten,
tuoi=@tuoi,
sex=@sex,
dia_chi=@dia_chi,
luong=@luong,
sdt=@sdt
where id=@id
end


create proc [dbo].[ThemNV]
@id int,@ten nvarchar(100),@tuoi int,@sex bit,@dia_chi nvarchar(50),@luong int,@sdt varchar(50)
as begin
SET IDENTITY_INSERT nhan_vien ON
insert into nhan_vien(id,ten,tuoi,sex,dia_chi,luong,sdt) values(@id,@ten,@tuoi,@sex,@dia_chi,@luong,@sdt)
SET IDENTITY_INSERT nhan_vien OFF
end


create proc [dbo].[TimkiemNV]
@ten nvarchar(50)
as begin 
select *from nhan_vien where nhan_vien.ten like '%'+@ten+'%'
end