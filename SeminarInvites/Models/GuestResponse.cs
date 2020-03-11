using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SeminarInvites.Models
{
    public class GuestResponse
    {
        //[Required]
        [Key]
        public int ResponseId { get; set; }
        [Required(ErrorMessage ="Please enter your name") ]

        public string Name{ get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",ErrorMessage ="Your email address is not in valid format. Ex. of correct email: paragjain@gmail.com")]

        public string Email { get; set; }

        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
       // public Nullable<bool> WillAttend { get; set; }

        public bool? WillAttend{ get; set; }


    }
}