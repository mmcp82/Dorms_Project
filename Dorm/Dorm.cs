using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Dorm
{
    internal class Dorm
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int ManagerID { get; set; }
        public string ManagerName { get; set; }
        public string Address { get; set; }

    }
}
