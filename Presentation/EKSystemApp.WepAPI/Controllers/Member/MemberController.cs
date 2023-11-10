﻿using EKSystemApp.Application.Features.Members.Cities.Queries;
using EKSystemApp.Application.Features.Members.Countries.Queries;
using EKSystemApp.Application.Features.Members.CountriesTree.Queries;
using EKSystemApp.Application.Features.Members.Education.Departments.Queries;
using EKSystemApp.Application.Features.Members.Education.Universities.Queries;
using EKSystemApp.Application.Features.Members.Education.UniversitiesTree.Queries;
using EKSystemApp.Application.Features.Members.Provinces.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Member
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Parametrik ülke kodu bilgisi ile ülke-il-ilçe ağaç yapısı içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]/{key?}")]
        public async Task<IActionResult> GetCountriesTreeById([FromRoute] int key = 220)
        {
            var result = await _mediator.Send(new GetEbaCountryTreeQueryRequest(key));
            return Ok(result);
        }

        /// <summary>
        /// Bütün ülkelerin listelendiği endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCountries()
        {
            var result = await _mediator.Send(new GetEbaCountryQueryRequest());
            return Ok(result);
        }
        
        /// <summary>
        /// Bütün illerin listelendiği endpoint, parametre verilirse ona bağlı illeri döndürür.
        /// Sadece Türkiye illeri listeleniyor, Parametrik upKey değeri ileriye dönük olarak eklenmiştir.
        /// </summary>
        [HttpGet("[action]/{key?}")]
        public async Task<IActionResult> GetAllProvinces([FromRoute] int upKey = 220)
        {
            var result = await _mediator.Send(new GetEbaProvinceQueryRequest(upKey));
            return Ok(result);
        }

        /// <summary>
        /// Parametrik upKey bilgisi verilen ilin ilçelerinin listelendiği endpoint
        /// </summary>
        [HttpGet("[action]/{upKey?}")]
        public async Task<IActionResult> GetAllCities([FromRoute] int upKey)
        {
            var result = await _mediator.Send(new GetEbaCityQueryRequest(upKey));
            return Ok(result);
        }

        /// <summary>
        /// Parametrik üniversite kodu bilgisi ile üniversite-bölüm ağaç yapısı içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]/{key?}")]
        public async Task<IActionResult> GetUniversitiesTreeById([FromRoute] int key)
        {
            var result = await _mediator.Send(new GetEbaUniversityTreeQueryRequest(key));
            return Ok(result);
        }

        /// <summary>
        /// Bütün üniversitelerin listelendiği endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUniversities()
        {
            var result = await _mediator.Send(new GetEbaUniversityQueryRequest());
            return Ok(result);
        }
        
        /// <summary>
        /// Parametrik upKey bilgisi verilen üniversite bölümlerinin listelendiği endpoint
        /// </summary>
        [HttpGet("[action]/{upKey?}")]
        public async Task<IActionResult> GetAllDepartments([FromRoute] int upKey)
        {
            var result = await _mediator.Send(new GetEbaEducationDeparmentQueryRequest(upKey));
            return Ok(result);
        }
    }
}
