using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Person.Collegian
{
    internal class Collegian:Person
    {
        public int ID { get; set; }
        public string Code { get; set;}
        public int AssignedRoomID { get; set;}
        public int IsBlockManager { get; set; }

    }
}
