﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.Cities
{
    [Table("Portal_ST_Ilce")]
    public class ST_Cities
    {
        [Key]
        public int ID { get; set; }
        public int UpKey { get; set; }
        public int Key { get; set; }
        public string Value { get; set; }
    }
}