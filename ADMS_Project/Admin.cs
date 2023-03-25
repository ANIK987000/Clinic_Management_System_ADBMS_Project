using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMS_Project
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

    }
}
