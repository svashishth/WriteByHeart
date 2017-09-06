using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KavitaDilSe.Entities.Models
{
    public class UserMasterModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailId { get; set; }

        public bool IsActiveUser { get; set; }

        public string UserStamp { get; set; }

        public DateTime TimeStamp { get; set; }

        
    }
}
