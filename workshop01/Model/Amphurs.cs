using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace workshop01.Model
{
    public class district
    {

        [Key]
        public int? amphur_id { get; set; }
        public string? amphur_name { get; set; }
        public int? province_id { get; set; }
        //public Nullable<System.DateTime> last_modify { get; set; }
    }
}

