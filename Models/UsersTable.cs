using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAlpha.Models
{
    public class UsersTable
    {

        [Key]
        public int UsersId { get; set; }

        public string UsersName { get; set; }

        [Required]
        public string UsersEmail { get; set; }
        public string UsersDOB { get; set; }

        [Required]
        public string UsersPassword { get; set; }
        public string UsersMobile { get; set; }
        public string UsersImages { get; set; }
        public string UsersAbout { get; set; }


    }
}
