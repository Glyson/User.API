using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User.API.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        //public int Age { get; set; }

        public string Company { get; set; }

        public string Title { get; set; }
    }
}
