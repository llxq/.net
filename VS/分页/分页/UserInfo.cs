using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 分页
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public DateTime LastErrorDatatime { get; set; }
        public int ErrorNumber { get; set; }
    }
}
