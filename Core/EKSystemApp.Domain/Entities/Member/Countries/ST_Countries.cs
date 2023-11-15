﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.Countries
{
    [Table("IseAlim_Ulke")]
    public class ST_Countries
    {
        [Key]
        public int ID { get; set; }
        public string TANIM { get; set; }
    }
}
