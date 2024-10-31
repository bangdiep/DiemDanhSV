using DiemDanhSV.Database;
using DiemDanhSV.Models;
using DiemDanhSV.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Controller
{

    internal class UsersController
    {
        private UsersRepository usersRepository = new UsersRepository();

        public List<Users> getAllUsers()
        {
            return usersRepository.findAll();
        }

        public Users getUsersByUsername(string username)
        {
            Users user = usersRepository.findByUsername(username);

            if (user == null)
            {
                throw new Exception("User does not exist!");
            } else
            {
                return user;
            }
            
        }

        public bool addUser(Users user)
        {
            return usersRepository.adddUser(user);
        }

    }
}
