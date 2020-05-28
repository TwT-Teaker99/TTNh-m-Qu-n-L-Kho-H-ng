CREATE VIEW ListRunOut AS WITH t1 as(
SELECT mat_hang_id,mat_hang.ten,mat_hang.remain,don_gia,ngay_nhap as datee,phieu_nhap_id 
FROM chi_tiet_phieu_nhap,phieu_nhap,mat_hang  
WHERE phieu_nhap.id=phieu_nhap_id AND mat_hang_id=mat_hang.id 
AND  mat_hang.remain<30 ) select t1.mat_hang_id,t1.ten,t1.remain,t1.don_gia,t1.datee,t1.phieu_nhap_id,
(CASE WHEN t1.remain=0 THEN N'Hết hàng' ELSE N'Sắp hết' END ) tinh_trang from t1 INNER JOIN 
(SELECT mat_hang_id,MAX(ngay_nhap) datee
FROM chi_tiet_phieu_nhap,phieu_nhap,mat_hang  
WHERE phieu_nhap.id=phieu_nhap_id AND mat_hang_id=mat_hang.id 
AND  mat_hang.remain<30 GROUP BY mat_hang_id) as t2 ON t1.mat_hang_id=t2.mat_hang_id AND t1.datee=t2.datee
SELECT *FROM ListRunOut ORDER BY tinh_trang







