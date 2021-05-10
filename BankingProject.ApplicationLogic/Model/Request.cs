﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ApplicationLogic.Model
{
    public class Request : DataEntity
    {
        public string Type { get; set; }
        public DateTime SendDate { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
