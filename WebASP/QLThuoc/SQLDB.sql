SELECT `thuoc`.`ThuocId`,
    `thuoc`.`MaThuoc`,
    `thuoc`.`Thuoc_ShortName`,
    `thuoc`.`Thuoc_FullName`
FROM `ql_thuoc`.`thuoc`;

    
  SELECT `donthuocnhap`.`DonThuocNhapId`,
    `donthuocnhap`.`SoHoaDon`,
    `donthuocnhap`.`NgayLap`,
    `donthuocnhap`.`NguoiLap`,
    `donthuocnhap`.`Cpty`,
    `donthuocnhap`.`GhiChu`
FROM `ql_thuoc`.`donthuocnhap`;


SELECT `chitietdonnhap`.`DonThuocNhapId`,
    `chitietdonnhap`.`ThuocId`,
    `chitietdonnhap`.`Soluong`,
    `chitietdonnhap`.`Dongia`
FROM `ql_thuoc`.`chitietdonnhap`;


 


