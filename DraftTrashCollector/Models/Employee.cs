﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DraftTrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Zipcode { get; set; }

        [ForeignKey("IdentityUser")] /*#ask why throwing error */
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
