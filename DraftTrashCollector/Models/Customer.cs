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
        [DisplayName("Street Address")]
        public int Address { get; set; }
        [DisplayName("Zip Code")]
        public int Zip { get; set; }
        [DisplayName("P-Up Day")]
        public int PickUpDay { get; set; }
        [DisplayName("Start Service Date")]
        public int StartServiceDate { get; set; }

        [ForeignKey("IdentityUser")] /*#ask why throwing error */
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
