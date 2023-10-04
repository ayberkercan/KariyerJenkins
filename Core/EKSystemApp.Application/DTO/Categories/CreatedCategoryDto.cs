﻿using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Categories
{
    public class CreatedCategoryDto : BaseEntity
    {
        public Guid AppUserId { get; set; }
        public Guid AppRoleId { get; set; }
    }
}
