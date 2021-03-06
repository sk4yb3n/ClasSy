﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClasSy.Models
{
    // Author: Emir Kurtanović
    [Table("Parents")]
    public class Parent : ApplicationUser
    {
        public virtual ICollection<Student> Students { get; set; }
    }
}