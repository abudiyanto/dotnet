﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class Person
    {
        [Key]
        public string IdPerson { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}



