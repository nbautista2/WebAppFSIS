﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSISSystem.ENTITIES
{
    [Table("Guardian")]
    class Guardian
    {
        public int GuardianID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmergencyPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
