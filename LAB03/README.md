\# BÁO CÁO THỰC HÀNH - LAB 03

\*\*HỆ THỐNG QUẢN LÝ KHÁCH SẠN\*\*



\---



\## 1. THÔNG TIN CÁ NHÂN

\* \*\*Họ và tên:\*\* \[LÊ TRẦN TẤN PHÁT]

\* \*\*Mã số sinh viên (MSSV):\*\* \[1250080137]

\* \*\*Lớp:\*\* \[12_ĐH_CNPM2]

\* \*\*Tên bài Lab:\*\* LAB 03 - Thiết kế \& Xây dựng Hệ thống Quản lý Khách sạn 



\---



\## 2. MÔI TRƯỜNG VÀ CÔNG NGHỆ (ENVIRONMENT)

\* \*\*Ngôn ngữ lập trình:\*\* C# (.NET Framework 4.7.2 / 4.8)

\* \*\*Môi trường phát triển (IDE):\*\* Microsoft Visual Studio 2019 / 2022

\* \*\*Hệ quản trị cơ sở dữ liệu:\*\* Microsoft SQL Server

\* \*\*Kiến trúc ứng dụng:\*\* Mô hình 3 lớp (3-Tier Architecture)

&#x20; \* `Data Tier`: `Db.cs` (Kết nối và thực thi SQL Server qua `System.Data.SqlClient`)

&#x20; \* `Business/Service Tier`: `DanhMucService.cs`, `PhongTienNghiService.cs`, `KetQuaXuLy.cs`

&#x20; \* `Presentation Tier`: `FrmMain`, `FrmDanhMuc`, `FrmPhongTienNghi`



\---



\## 3. NỘI DUNG ĐÃ THỰC HIỆN (IMPLEMENTED FEATURES)



\### A. Mô hình 3 lớp \& Cơ sở dữ liệu

\* Xây dựng lớp `Db.cs` dùng chung để thực thi các truy vấn SQL (`Query`, `Execute`).

\* Tạo lớp `KetQuaXuLy.cs` chuẩn hóa phản hồi từ Service về UI (Trạng thái + Thông báo).

\* Cấu hình chuỗi kết nối linh hoạt trong `App.config`.



\### B. Form Quản lý Danh mục (`FrmDanhMuc`)

\* \*\*Khu vực:\*\* Lấy danh sách và thêm mới Khu vực.

\* \*\*Nhân viên:\*\* Lấy danh sách và thêm Nhân viên (mã, tên, vai trò, SĐT).

\* \*\*Loại tiện nghi:\*\* Quản lý danh mục Loại tiện nghi.

\* \*\*Dịch vụ:\*\* Quản lý Dịch vụ (mã, tên, đơn vị tính, đơn giá).

\* \*\*Quy định đền bù:\*\* Thêm quy định đền bù liên kết ComboBox với Loại tiện nghi.



\### C. Form Quản lý Phòng \& Tiện nghi (`FrmPhongTienNghi`)

\* \*\*Tab 1 - Quản lý Phòng:\*\* Thêm thông tin phòng, chọn khu vực, gán sức chứa và đơn giá.

\* \*\*Tab 2 - Quản lý Tiện nghi:\*\* Thêm thiết bị/tiện nghi cụ thể, phân loại và tình trạng.

\* \*\*Tab 3 - Lắp đặt / Luân chuyển:\*\* Lập phiếu trang bị/luân chuyển tiện nghi vào phòng, ghi nhận ngày, nhân viên phụ trách và tình trạng.



\---



\## 4. KẾT QUẢ ĐẠT ĐƯỢC (RESULTS)

\* Giao diện UI thiết kế đúng chuẩn TabControl, bố cục rõ ràng, dễ thao tác.

\* `DataGridView` tự động căn chỉnh lấp đầy giao diện (`AutoSizeColumnsMode = Fill`).

\* Tự động xóa trắng dữ liệu ô nhập liệu (Clear Input) sau khi thêm mới thành công.

\* Xử lý ngoại lệ (`try-catch`) toàn diện, đảm bảo ứng dụng không bị crash khi mất kết nối CSDL.



\---



\## 5. LỖI GẶP PHẢI VÀ CÁCH KHẮC PHÚC (ERRORS \& FIXES)



| STT | Lỗi gặp phải | Nguyên nhân | Cách khắc phục |

| :--- | :--- | :--- | :--- |

| \*\*1\*\* | Màn hình WinForms Designer báo lỗi \*"does not support code parsing..."\* | Mở dự án ở chế độ \*\*Open Folder\*\* thay vì file Solution (`.sln`). | Tắt VS, mở dự án bằng cách đúp chuột vào file \*\*`QuanLyKhachSan.sln`\*\*. |

| \*\*2\*\* | Designer báo lỗi không tìm thấy sự kiện (`tpKhuVuc\_Click`, `button1\_Click`,...) | Lỡ click đúp tạo sự kiện rác sau đó xóa hàm trong file `.cs` nhưng chưa xóa trong Designer. | Mở file `.Designer.cs` xóa dòng đăng ký sự kiện mồ côi hoặc tạo hàm rỗng trong file code `.cs`. |

| \*\*3\*\* | `DataGridView` bị màu xám, không lên dữ liệu khi chạy | Quên chưa nối sự kiện `Load` của Form với hàm `Frm\_Load` trên Designer. | Bấm vào Form $\\rightarrow$ Bảng \*\*Properties (⚡ Events)\*\* $\\rightarrow$ Chọn sự kiện \*\*`Load`\*\*. |

| \*\*4\*\* | `DataGridView` hiển thị cột bị thừa khoảng xám bên phải | Thuộc tính `AutoSizeColumnsMode` mặc định là `None`. | Đổi `AutoSizeColumnsMode` thành \*\*`Fill`\*\* trên Designer hoặc gán qua code. |



\---



\## 6. HƯỚNG DẪN KIỂM TRA VÀ CHẠY DỰ ÁN (GUIDE FOR LECTURER)



\### Bước 1: Chuẩn bị Cơ sở dữ liệu (SQL Server)

1\. Mở \*\*SQL Server Management Studio (SSMS)\*\*.

2\. Chạy file script SQL đính kèm (`QuanLyKhachSan.sql`) để tạo Database và các bảng dữ liệu mẫu.



\### Bước 2: Cấu hình Chuỗi kết nối

1\. Mở file \*\*`App.config`\*\* trong project `QuanLyKhachSan`.

2\. Thay đổi giá trị `Data Source` thành tên SQL Server của máy kiểm tra:

&#x20;  ```xml

&#x20;  <connectionStrings>

&#x20;      <add name="DbConnectionString" 

&#x20;           connectionString="Data Source=YOUR\_SERVER\_NAME;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True" 

&#x20;           providerName="System.Data.SqlClient" />

&#x20;  </connectionStrings>

