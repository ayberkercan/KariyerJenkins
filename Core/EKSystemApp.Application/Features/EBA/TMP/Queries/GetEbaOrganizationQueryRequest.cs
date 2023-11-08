﻿using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaOrganizationQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
    }
}
