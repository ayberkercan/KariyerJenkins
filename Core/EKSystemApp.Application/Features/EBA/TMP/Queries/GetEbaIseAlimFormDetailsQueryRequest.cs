﻿using EKSystemApp.Application.DTO.Eba.EbaUnit;
using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class GetEbaIseAlimFormDetailsQueryRequest : IRequest<EbaIseAlimTurkuvazFormDto>
    {
        public CheckEbaIseAlimFormDetailsQueryRequest Request { get; set; }
        public GetEbaIseAlimFormDetailsQueryRequest(CheckEbaIseAlimFormDetailsQueryRequest request)
        {
            Request = request;
        }
    }
}