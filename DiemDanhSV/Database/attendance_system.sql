create database attendance_system;

use attendance_system;

-- Tạo bảng
create table Users (
    userID char(8),
    fullName varchar(60),
    userName varchar(30),
    passwords varchar(20),
    email varchar(28),
    gender varchar(6),
    roles int,
    constraint Pk_us primary key (userID)
);

create table Student (
    stdID char(8),
    major varchar(60),
    constraint Pk_st primary key (stdID),
    constraint Fk_st_us foreign key (stdID) references Users(userID)
);

create table Instructor (
    inID char(8),
    degree varchar(60),
    constraint Pk_in primary key (inID),
    constraint Fk_in_us foreign key (inID) references Users(userID)
);

create table Subjects (
    subID char(6),
    subjectName varchar(100),
    constraint Pk_sj primary key (subID)
);

create table Shifts (
    shiftID char(3),
    timeStart time,
    timeEnd time,
    constraint Pk_sh primary key (shiftID)
);

create table Class (
    classID char(8),
    Ctype varchar(6),
    room varchar(5),
    term varchar(10),
    tcID char(8),
    sjID char(6),
    shID char(3),
    constraint Pk_c primary key (classID),
    constraint Fk_c_tc foreign key (tcID) references Instructor(inID),
    constraint Fk_c_sj foreign key (sjID) references Subjects(subID),
    constraint Fk_c_sh foreign key (shID) references Shifts(shiftID)    
);

create table Lists (
    stdID char(8),
    cID char(8),
    term varchar(10),
    constraint Pk_us primary key (stdID, cID),
    constraint Fk_l_c foreign key (cID) references Class(classID),
    constraint Fk_l_st foreign key (stdID) references Student(stdID)
);

create table Attendance (
    stdID char(8),
    cID char(8),
    timeAttend time,
    constraint Pk_at primary key (stdID, cID),
    constraint Fk_at_c foreign key (cID) references Class(classID),
    constraint Fk_at_st foreign key (stdID) references Student(stdID)
);

create table Subject_Shift (
    subID char(6),
    shID char(3),
    term varchar(10),
    dayAssign varchar(10),
    constraint Pk_ss primary key (subID, shID),
    constraint Fk_ss_sj foreign key (subID) references Subjects(subID),
    constraint Fk_ss_sh foreign key (shID) references Shifts(shiftID)
);