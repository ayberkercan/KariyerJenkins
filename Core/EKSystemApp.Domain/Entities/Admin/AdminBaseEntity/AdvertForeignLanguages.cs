﻿using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class AdvertForeignLanguages : BaseEntity
    {
        public string? ForeignLanguageKey { get; set; }
        public string? ForeignLanguageName { get; set; }
        public string? ForeignLanguageLevels { get; set; }
        public Guid? AdvertCreateId { get; set; }
        public AdvertCreate? AdvertCreate { get; set; }

    }
}
