﻿using EKSystemApp.Application.DTO.Eba.EbaUnit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.EbaUnits.Queries
{
    public class GetEbaUnitsQueryRequest : IRequest<ICollection<EbaUnitDto>>
    {
    }
}
