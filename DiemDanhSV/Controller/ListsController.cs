using ClosedXML.Excel;
using DiemDanhSV.Models;
using DiemDanhSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSV.Controller
{
    internal class ListsController
    {
        private readonly ListsRepository listsRepository = new ListsRepository();

        public bool addLists(Lists lst)
        {
            return listsRepository.AddList(lst);
        }

        public List<Lists> ReadListsFromExcel(string filePath)
        {
            var lists = new List<Lists>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                foreach (var row in worksheet.RangeUsed().RowsUsed().Skip(1)) // skip first row
                {
                    string studentID = row.Cell(1).GetString();
                    var classID = row.Cell(2).GetString();
                    var term = row.Cell(3).GetString();
                    lists.Add(new Lists
                    (
                        studentID,
                        classID,
                        term
                    ));
                }
            }
            return lists;
        }

        public bool addListsFromList(List<Lists> lists)
        {
            foreach (Lists lst in lists)
            {
                bool result = this.addLists(lst);
                if (result == false)
                {
                    throw new Exception($"Cannot add student with ID: {lst.StdID} into class with ID: {lst.CID}");
                }
            }
            return true;
        }

        public List<Classes> getAllClassExist()
        {
            return listsRepository.findAllClassExist();
        }

        public int getToTalStudentInClass(string id)
        {
            return listsRepository.CountByCID(id);
        }
    }
}
