using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Models
{
    internal class Lists
    {
        public string StdID { get; set; }  // Mã sinh viên
        public string CID { get; set; }    // Mã lớp
        public string Term { get; set; }   // Học kỳ

        public Lists() { }

        public Lists(string stdID, string cID, string term)
        {
            StdID = stdID;
            CID = cID;
            Term = term;
        }
    }
}
