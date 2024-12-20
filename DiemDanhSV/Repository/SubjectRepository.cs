﻿using DiemDanhSV.Database;
using DiemDanhSV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Repository
{
    internal class SubjectRepository
    {
        public bool AddSubject(Subject subject)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Subjects (subID, subjectName) VALUES (@subID, @subjectName)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@subID", subject.SubjectId);
                    cmd.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                    int result = cmd.ExecuteNonQuery();

                    return result > 0; // Trả về true nếu thêm thành công
                }
            }
        }

        public List<Subject> findAll()
        {
            List<Subject> subjects = new List<Subject>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Subjects";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Subject subject = Subject.FromDataReader(reader);
                            subjects.Add(subject);
                        }
                    }
                }

                return subjects;
            }
        }

        public Subject getSubjectByID(string id)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Subjects WHERE subID = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Subject.FromDataReader(reader);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}
