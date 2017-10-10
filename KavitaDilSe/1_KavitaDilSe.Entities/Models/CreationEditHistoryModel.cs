using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KavitaDilSe.Entities.Models
{
    public class CreationEditHistoryModel
    {
        [Key]
        public int HistoryId { get; set; }

        public CreationsStoreModel CreationId { get; set; }

        public string CreationOldContent { get; set; }

        public string CreationNewContent { get; set; }

        public string UserStamp { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
