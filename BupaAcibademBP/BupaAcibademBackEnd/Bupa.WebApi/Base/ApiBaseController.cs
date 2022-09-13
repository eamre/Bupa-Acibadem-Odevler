using Bupa.Entity.Base;
using Bupa.Entity.IBase;
using Bupa.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bupa.WebApi.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController<TInterface, T, TDto> : ControllerBase
        where TInterface : IGenericService<T, TDto>
        where T : EntityBase
        where TDto : DtoBase

    {
        private readonly TInterface service;

        public ApiBaseController(TInterface service)
        {
            this.service = service;
        }

        [HttpGet("Find")]
        public IResponse<TDto> Find(int id)
        {
            try
            {
                var entity = service.Find(id);

                return entity;
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

        [HttpPost("Add")]
        public IResponse<TDto> Add(TDto dto)
        {
            try
            {
                return service.Add(dto);
            }
            catch(Exception ex)
            {
                return new Response<TDto>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };

            }

        }

        [HttpGet("GetAll")]
        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                return service.GetAll();
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
