using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大项目
{
    class ClassInformation
    {
        private int _id;
        private string _studentNumber;
        private string _cNONumber;  //课程号
        private string _courseId;  //课程编号
        private string _credit;

        public int Id { get => _id; set => _id = value; }
        public string StudentNumber { get => _studentNumber; set => _studentNumber = value; }
        public string CNONumber { get => _cNONumber; set => _cNONumber = value; }
        public string CourseId { get => _courseId; set => _courseId = value; }
        public string Credit { get => _credit; set => _credit = value; }
    }
}
