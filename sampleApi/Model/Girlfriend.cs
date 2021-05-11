using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sampleApi.Model
{
    public class Girlfriend
    {
        [Key]
        public int Gid { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public DateTime? Dob { get; set; }


    }
}
