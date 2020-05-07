USE QuanLyKhoHang
GO

INSERT INTO nhan_vien
	(ten , tuoi ,sex ,dia_chi ,luong ,sdt ,manager_id)
	VALUES	
		(N'Lê Minh Quang' , 20 , 1 , N'Thanh Hóa' , 2300 , '0532908161' , 5 ),
		(N'Nguyễn Vinh Anh' , 21 , 1 , N'Vũng Tàu' , 4000 , '032765354' , 5 ),
		(N'Nguyễn Văn Linh' , 19 , 1 , N'Hà Nội' , 1000 , '0653908162' , 2 ),
		(N'Trần Hoàng Giang' , 19 , 1 , N'Ninh Bình' , 1000 , '0543908163' , 2 ),
		(N'Tào Đức Việt' , 23 , 1 , N'Vinh' , 5000 , '0123908164' ,5  );
GO

INSERT INTO loai_hang
(ten)
VALUES (  N'Đồ Công nghệ' ),
		( N'Thực Phẩm' ),
		( N'Sách' ),
		( N'Đồ chơi' ),
		( N'Quần Áo' );
GO


INSERT INTO quay
	(ten,nhan_vien_id)
VALUES  ( N'Quầy 103', 1  ),
		( N'Quầy 104', 2  ),
		( N'Quầy 105', 3  ),
		( N'Quầy 106', 4  ),
		( N'Quầy 107', 5  );
GO


INSERT INTO mat_hang
	(quay_id,loai_hang_id,ten)
	VALUES
	( 1, 2, N'Sữa Chua'),
	( 2, 2, N'Cam'),
	( 3, 1, N'Laptop Asus'),
	( 4, 4, N'Sách Vật Lý'),
	( 5, 3, N'Sách God Father');	
	GO

INSERT INTO phieu_tra
	(quay_id,nhan_vien_id,ngay_tra)
	VALUES
	( 2, 2, '20161110' ),
	( 3, 3, '20161111' ),
	( 4, 1, '20161112'  ),
	( 5, 5, '20161113'  ),
	( 1, 4, '20161114'  );
GO
INSERT INTO chi_tiet_phieu_tra
	(phieu_tra_id, mat_hang_id,  so_luong	)
		VALUES
		( 1, 2, 13 ),
		( 3, 3, 25 ),
		( 5, 4, 3  ),
		( 2, 5, 32 ),
		( 4, 1, 18 );

 GO


 INSERT INTO nha_cung_cap
 ( ten, sdt,phuong, quan, city )
	VALUES  
		( N'Clean Food','0293213213', N'Quang Lý', N'Lê Minh',N'Hồ Chí Minh' ),
		( N'Microsoftial','02394711834', N'Thiên Đại', N'Quang Thắng',N'Vũng Tàu' ),
		( N'BookStore Y&G','0394829134', N'Hoa Đà', N'Linh Đồng',N'Cần Thơ' );
		
		GO

INSERT INTO mat_hang
(quay_id,loai_hang_id,ten)
	VALUES
	( 1, 3, N'Sách dạy nấu ăn'),( 3, 2, N'Bánh mì kinh đô'),
	( 2, 1, N'Điện thoại bàn') ,( 2, 1, N'Tivi A14'),
    ( 2, 1, N'LapTop Dell')    ,( 2, 1, N'SamSung Galaxy S7'),
	( 3, 2, N'bánh chocopie')  ,( 3, 2, N'cơm đóng hộp'),
	( 3, 2, N'trà gói')        ,( 1, 3, N'Sách luật im lặng'),
	( 1, 3, N'Sách Hóa Học')   ,( 1, 3, N'Sách Tiếng Anh');

	GO

 INSERT INTO phieu_nhap
(   ncc_id,   nhan_vien_id,   ngay_nhap)
VALUES 	( 1,1, '20190110'),( 2,2, '20190513'),( 2,2, '20190525'),
		( 1,1, '20190602'),( 3,5, '20190603'),( 3,4, '20190801'),
		( 3,4, '20190809'),( 2,3, '20190810'),( 1,1, '20191207');

GO
INSERT INTO chi_tiet_phieu_nhap
	( phieu_nhap_id,   mat_hang_id,  so_luong,   don_gia ,don_vi)
		VALUES
		( 1 ,7 ,20 ,100,N'hộp' ),( 1 ,12 ,35 ,230 ),
		( 2 ,8 ,30 ,270 ),
		( 3 ,3 ,10 ,380 ),( 3 ,10 ,18 ,390 ),
		( 4 ,1 ,15 ,870 ),
		( 5 ,6 ,26 ,350 ),
		( 6 ,5 ,21 ,120 ),( 6 ,15 ,25 ,420 ),( 6 ,16 ,25 ,130 ),( 6 ,17 ,20 ,220 ),
		( 7 ,4 ,12 ,3000),
		( 8 ,9 ,15 ,100 ),( 8 ,11 ,18 ,2000),
		( 9 ,2 ,25 ,50  ),( 9 ,13 ,24 ,600 ),( 9 ,14 ,30 ,1000 );
