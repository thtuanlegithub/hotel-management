# Hotel Management

Ứng dụng Quản lý khách sạn cơ bản được xây dựng trên nền tảng WinForms với giao diện hiện đại.

## Tính năng

- Hiển thị trạng thái các phòng theo sơ đồ 1 cách trực quan.
- Quản lý phòng.
- Quản lý loại phòng.
- Quản lý đặt phòng.
- Quản lý hóa đơn.
- Quản lý các loại dịch vụ.
- Quản lý các loại tiện nghi.
- Quản lý thông tin cơ bản nhân viên.
- Quản lý thông tin cơ bản khách hàng.
- Quản lý loại tài khoản sử dụng ứng dụng.
- Thống kê doanh thu.
- In hóa đơn.
- Hỗ trợ lấy lại và thay đổi mất khẩu.
- Xuất file Excel các loại danh sách.
- Phân quyền cấp độ các loại tài khoản.

Ngôn ngữ: Tiếng Việt.

## Yêu cầu cài đặt

- Môi trường chạy chương trình:

   - Windows 8.1+.
   - .NET Framework 4.7.2.
   - Microsoft SQL Server 2021+.
   - Microsoft Visual Studio 2022+.

- Môi trường phát triển phần mềm:

   - Microsoft Visual Studio 2022+.
   - Microsoft SQL Server 2021+.

## Hướng dẫn cài đặt

1. Đầu tiên, khởi động ứng dụng Microsoft SQL Server Management Studio:

    - B1: Lấy Server name khi vừa khởi động ứng dụng này.

    - B2: Chạy file SQLHotelManagement.sql và bạn có thể tạo tên của Database tùy ý. Mặc định là "HotelManagement".

    **Đặc biệt chú ý sử dụng Authentication là Windows Authentication.**

2. Bây giờ, mở file HotelManagement.sln bằng Visual Studio.

3. Cài đặt hoàn tất, bạn đã có thể nhấn "Run" chạy chương trình (Phím tắt trong Visual Studio là F5). Lúc này ứng dụng sẽ hỏi "Nhập tên server" (B1) và "Nhập tên Database" (B2) mà bạn đã có lúc nãy.

> Để tiện việc sử dụng Demo, nhóm có tạo một CSDL mặc định. Bạn có thể dùng ngay CSDL tại đó. Tài khoản mặc định là admin, mật khẩu là 1234.
 (Lưu ý: Nếu sử dụng CSDL mặc định thì khi tắt chương trình, dữ liệu sẽ không được lưu lại).

## Tác giả

[Nguyễn Phúc Bình](https://github.com/leesoonduck3009)

[Phan Tuấn Thành](https://github.com/thanhpt1110)

[Lê Thanh Tuấn](https://github.com/thtuanlegithub)
