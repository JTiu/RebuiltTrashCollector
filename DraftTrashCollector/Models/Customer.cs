using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DraftTrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Street Address")]
        public string StreetAddress { get; set; }
        [DisplayName("Balance")]
        public double Balance { get; set; }

        [DisplayName("Pick Up Day")]
        public string PickUpDay { get; set; }
        [DisplayName("Extra Pick Up Day")]
        public DateTime ExtraPickupDay { get; set; }


        

        [ForeignKey("IdentityUser")] /*#ask why throwing error */
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
