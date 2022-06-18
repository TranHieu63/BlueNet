using System;

namespace BlueNet.Api.Entities
{
    public class Violation
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
