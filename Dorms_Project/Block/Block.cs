using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Block
{
    internal class Block
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Floors { get; set; }
        public int Rooms { get; set; }
        public int ManagerID { get; set; }
        public string ManagerName { get; set; }
        public int LinkedDormID { get; set; }
    }
}
    
