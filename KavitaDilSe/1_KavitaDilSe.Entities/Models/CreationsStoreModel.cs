using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KavitaDilSe.Entities.Models
{
    public class CreationsStoreModel
    {
        [Key]
        public int CreationId { get; set; }

        public CreationTypeMasterModel CreationTypeId { get; set; }

        public string CreationContent { get; set; }

        public string UserStamp { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
