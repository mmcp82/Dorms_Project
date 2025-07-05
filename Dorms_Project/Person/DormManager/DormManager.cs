using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Person.DormManager
{
    internal class DormManager:Person
    {
        public int ID { get; set; }
        public string Job { get; set; }
        public int ManagingDormID { get; set; }
        public string ManagingDormName { get; set; }
    }
}
