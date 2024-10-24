use attendance_system;

-- Thêm data mẫu
insert into Users
    values ('52200210', 'Tang Duy Hao', 'haotang', '12345', '52200210@student.tdtu.edu.vn', 'Male'),
        ('52200238', 'Diep Truong Khanh Bang', 'bangdiep', '12345', '52200238@student.tdtu.edu.vn', 'Female'),
        ('52200243', 'Ho Bao Ngan', 'nganho', '12345', '52200243@student.tdtu.edu.vn', 'Female');


insert into Student
    values ('52200238', 'Mang may tinh va truyen thong du lieu'),
        ('52200243', 'Khoa hoc may tinh');


insert into Instructor
    values ('52200210', 'Doctorate');


insert into Subjects
    values ('502045', 'Cong nghe phan mem'),
        ('502046', 'Nhap mon Mang may tinh');


insert into Shifts 
    values ('S01', '06:50:00', '09:20:00'),
        ('S02', '09:30:00', '11:50:00'),
        ('S03', '12:45:00', '15:15:00'),
        ('S04', '15:25:00', '17:55:00');


insert into Class
    values ('50204501', 'Ly thuyet', 'C0301', 'HK1-24-25', '52200210', '502045', 'S03'),
        ('50204502', 'Thuc hanh', 'A0508', 'HK1-24-25', '52200210', '502045', 'S04');


insert into Lists
    values ('52200238', '50204501', 'HK1-24-25'),
        ('52200238', '50204502', 'HK1-24-25'),
        ('52200243', '50204501', 'HK1-24-25');


insert into Subject_Shift
    values ('502045', 'S03', 'HK1-24-25', 'Tuesday'),
        ('502046', 'S02', 'HK2-23-24', 'Wednesday');


insert into Attendance
    values ('52200238', '50204501', '13:00:00'),
        ('52200243', '50204501', '15:16:00');