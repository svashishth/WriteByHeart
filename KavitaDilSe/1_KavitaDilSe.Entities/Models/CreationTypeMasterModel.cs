﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KavitaDilSe.Entities.Models
{
    public class CreationTypeMasterModel
    {
        public int Id { get; set; }

        public string TypeName { get; set; }

        public string UserStamp { get; set; }

        public DateTime TimeStamp { get; set; }
        
    }
}