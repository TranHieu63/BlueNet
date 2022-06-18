using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueNet.Models
{
    public class ViolationParameter
    {
        public Guid ViolationId { get; set; }
        public string Url { get; set; }
        public string ComputerName { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid HandwareId { get; set; }
        public string IpLocal { get; set; }
        public Guid UserId { get; set; }
    }
}
