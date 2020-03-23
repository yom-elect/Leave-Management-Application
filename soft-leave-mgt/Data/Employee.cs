using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using soft_leave_mgt.Data;

namespace soft_leave_mgt.Data
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }

    }
}
