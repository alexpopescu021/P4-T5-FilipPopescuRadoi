using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.ApplicationLogic.Model
{
    public class CardMetaData : DataEntity
    {
        public int Color { get; set; }
        public Guid CardId { get; set; }
    }
}
