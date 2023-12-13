﻿using EKSystemApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.File
{
    public class FormFilesDto : BaseEntity
    {
        public string FileName { get; set; }
        public string FileData { get; set; }
        public string Owner { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
