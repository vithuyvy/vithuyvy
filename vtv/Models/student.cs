using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace vtv.Models
{
    public class student : person
    {
        public string Truong { get; set; }
    }
}