using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Block
{
    internal class Room
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int CurrentCapacity { get; set; }
        public int LinkedBlockID { get; set; }

    }
}
