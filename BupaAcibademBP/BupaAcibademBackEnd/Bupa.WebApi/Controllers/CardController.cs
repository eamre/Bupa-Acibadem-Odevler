using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using Bupa.Interface;
using Bupa.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bupa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ApiBaseController<ICardService, Card, DtoCard>
    {
        private readonly ICardService cardService;

        public CardController(ICardService cardService) : base(cardService)
        {
            this.cardService = cardService;
        }

    }
}
