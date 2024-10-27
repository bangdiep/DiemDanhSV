use attendance_system;

-- Thêm data mẫu vào bảng Users
INSERT INTO Users (userID, fullName, userName, passwords, email, gender, roles)
VALUES 
    ('52200210', 'Tang Duy Hao', 'haotang', '12345', '52200210@student.tdtu.edu.vn', 'Male', 1),
    ('52200238', 'Diep Truong Khanh Bang', 'bangdiep', '12345', '52200238@student.tdtu.edu.vn', 'Female', 2),
    ('52200243', 'Ho Bao Ngan', 'nganho', '12345', '52200243@student.tdtu.edu.vn', 'Female', 2);

-- Thêm data mẫu vào bảng Student
INSERT INTO Student (stdID, major)
VALUES 
    ('52200238', 'Mang may tinh va truyen thong du lieu'),
    ('52200243', 'Khoa hoc may tinh');

-- Thêm data mẫu vào bảng Instructor
INSERT INTO Instructor (inID, degree)
VALUES 
    ('52200210', 'Doctorate');

-- Thêm data mẫu vào bảng Subjects
INSERT INTO Subjects (subID, subjectName)
VALUES 
    ('502045', 'Cong nghe phan mem'),
    ('502046', 'Nhap mon Mang may tinh');

-- Thêm data mẫu vào bảng Shifts
INSERT INTO Shifts (shiftID, timeStart, timeEnd)
VALUES 
    ('S01', '06:50:00', '09:20:00'),
    ('S02', '09:30:00', '11:50:00'),
    ('S03', '12:45:00', '15:15:00'),
    ('S04', '15:25:00', '17:55:00');

-- Thêm data mẫu vào bảng Class
INSERT INTO Class (classID, Ctype, room, term, tcID, sjID, shID)
VALUES 
    ('50204501', 'Ly thuyet', 'C0301', 'HK1-24-25', '52200210', '502045', 'S03'),
    ('50204502', 'Thuc hanh', 'A0508', 'HK1-24-25', '52200210', '502045', 'S04');

-- Thêm data mẫu vào bảng Lists
INSERT INTO Lists (stdID, cID, term)
VALUES 
    ('52200238', '50204501', 'HK1-24-25'),
    ('52200238', '50204502', 'HK1-24-25'),
    ('52200243', '50204501', 'HK1-24-25');

-- Thêm data mẫu vào bảng Subject_Shift
INSERT INTO Subject_Shift (subID, shID, term, dayAssign)
VALUES 
    ('502045', 'S03', 'HK1-24-25', 'Tuesday'),
    ('502046', 'S02', 'HK2-23-24', 'Wednesday');

-- Thêm data mẫu vào bảng Attendance
INSERT INTO Attendance (stdID, cID, timeAttend)
VALUES 
    ('52200238', '50204501', '13:00:00'),
    ('52200243', '50204501', '15:16:00');