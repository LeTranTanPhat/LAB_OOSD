\# Lab 5 – Phân tích hệ thống quản lý tour du lịch



\## 1. Thông tin sinh viên



| Mục | Nội dung |

| --- | --- |

| Họ và tên | Lê Trần Tấn Phát |

| MSSV | 1250080137 |

| Lớp / Học phần | 12\_ĐH\_CNNPMT2 / Phát triển phần mềm hướng đối tượng |

| Tên bài Lab | Lab 5 – Phân tích hệ thống quản lý tour du lịch của Công ty Du lịch Văn Hóa Việt TP.HCM |



\## 2. Nội dung đã thực hiện



Bài lab phân tích nghiệp vụ và xác định Use Case cho hệ thống quản lý tour du lịch, gồm hai chương trong file `Baocaolab5`.



\*\*Chương 1 – Giới thiệu\*\*

\- 1.1. Tổng hợp 11 yêu cầu nghiệp vụ (quản lý tour, khách đoàn, khách lẻ, đặt cọc/thanh toán, nhân viên hướng dẫn, lương, nơi dừng chân – phương tiện, điểm tham quan, khảo sát...).

\- 1.2. Bảng Đầu vào – Xử lý – Đầu ra.

\- 1.3. Xác định 4 tác nhân: khách đoàn, khách lẻ, nhân viên hướng dẫn, công ty du lịch.

\- 1.4. Bảng yêu cầu chức năng (YC01 – YC19).

\- 1.5. Bảng yêu cầu phi chức năng (PYC01 – PYC05).



\*\*Chương 2 – Phân tích\*\*

\- 2.1. Bảng xác định 15 Use Case (UC01 – UC15).

\- 2.2. Sơ đồ Use Case tổng quát, trong đó "Cung cấp danh sách người mua bảo hiểm" có quan hệ `extend` với "Đăng ký tour theo đoàn".

\- 2.2.1. Phân rã sơ đồ Use Case.

\- 2.3. Đặc tả chi tiết các Use Case (tên, tác nhân, mục đích, điều kiện trước, luồng chính, luồng ngoại lệ, kết quả).



\## 3. Kết quả



\- Xác định đầy đủ các tác nhân, 19 yêu cầu chức năng, 5 yêu cầu phi chức năng và 15 Use Case.

\- Có sơ đồ Use Case tổng quát và sơ đồ phân rã (2 hình trong file Word).

\- Đặc tả chi tiết các Use Case theo mẫu bảng thống nhất.

\- Những tình huống đề bài không quy định (số tiền cọc, công thức tính lương, cách xử lý khi khách không phản hồi khảo sát...) được ghi rõ là "đề bài chưa quy định" thay vì tự đặt giả định.



\## 4. Lỗi gặp phải và cách khắc phục



> Phần này cần sinh viên điền theo thực tế làm bài. Dưới đây là các điểm mình thấy trong file để bạn đối chiếu; chỉ giữ lại những mục đúng với trải nghiệm của bạn.



| STT | Lỗi gặp phải | Cách khắc phục |

| --- | --- | --- |

| 1 | Mã yêu cầu YC11 bị gõ sai thành `Yc011` trong bảng 1.4 | Sửa lại thành `YC11` |

| 2 | Danh sách Use Case ở mục 2.1 (UC01 – UC15) không khớp với phần đặc tả ở mục 2.3 (ví dụ UC01 xem tour, nhưng UC02 ở 2.1 là "Quản lý thông tin tour" còn ở 2.3 là "Đăng ký tour theo đoàn") | Đánh số lại để mã và tên Use Case thống nhất giữa 2.1, sơ đồ và 2.3 |

| 3 | Lỗi chính tả: "khách hang", "Quản ký", "đăng kí", "nói đến" | Soát lại chính tả toàn bộ văn bản |

| 4 | `<Lỗi khác bạn gặp, ví dụ: vẽ sơ đồ, extend/include, xuất hình>` | `<Cách xử lý>` |





