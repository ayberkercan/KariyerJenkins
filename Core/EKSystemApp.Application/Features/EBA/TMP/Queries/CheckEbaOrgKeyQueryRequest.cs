﻿using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaOrgKeyQueryRequest : IRequest<ICollection<EbaKvpDto>>
    {
        public int UserId { get; set; }
        public CheckEbaOrgKeyQueryRequest(int UserId)
        {
            this.UserId = UserId;
        }
    }
}
