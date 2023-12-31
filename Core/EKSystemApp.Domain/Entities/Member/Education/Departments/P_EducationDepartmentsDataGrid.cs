﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKSystemApp.Domain.Entities.Member.Education.Departments
{
    [Keyless]
    [Table("E_mrs_IseAlimTurkuvaz_P_BolumTanimlama_dtyBolum")]
    public class P_EducationDepartmentsDataGrid
    {
        public int FORMID { get; set; }
        public int ORDERID { get; set; }
        public int DOCUMENTID { get; set; }
        public int CHECKED { get; set; }
    }
}
