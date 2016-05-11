create proc login_form
@taikhoan nvarchar(20),
@matkhau nvarchar(20)
as
select * from NguoiDung where TaiKhoan = @taikhoan and MatKhau= @matkhau


create proc kiemtraquyen
@taikhoan nvarchar(20)
as
select Quyen from NguoiDung where TaiKhoan=@taikhoan


create proc kiemtracauhoi
@taikhoan nvarchar(20)
as
select CauHoiBM from NguoiDung where TaiKhoan=@taikhoan


create proc UpdateNguoiDung
(@taikhoan nvarchar(20),@matkhau nvarchar(20))
as
update NguoiDung set MatKhau=@matkhau where TaiKhoan=@taikhoan

create proc xacnhan
@taikhoan nvarchar(20)
as
select TraLoi from NguoiDung where TaiKhoan=@taikhoan

create proc Timmalop
@malop nchar(9)
as 
select * from HocSinh where MaLop=@malop