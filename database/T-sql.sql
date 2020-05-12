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

