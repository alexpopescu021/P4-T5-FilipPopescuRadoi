
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ApplicationLogic.Model
{
    public enum RequestStatus
    {
        Waiting,
        Accepted,
        Rejected
    }
    public class Request : DataEntity
    {
        public string Type { get; set; }
        public DateTime SendDate { get; set; }
        public RequestStatus Status { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
