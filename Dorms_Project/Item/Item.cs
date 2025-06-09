using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Project.Item
{
    internal class Item
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string PartNumber { get; set; }
        public string _8DigitsID { get; set; }
        public string State { get; set; }
        public int LinkedRoomID { get; set; }
        public int LinkedCollegianID { get; set; }

    }
}
