using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumberAPI.Data;
using NumberAPI.DTOs;
using NumberAPI.Models;
using System.Collections.Generic;

namespace NumberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumItemController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly INumItemRepo _numItemRepo;

        public NumItemController(IMapper mapper, INumItemRepo numItemRepo)
        {
            _mapper = mapper;
            _numItemRepo = numItemRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<NumItemReadDto>> GetAllNumItems()
        {
            var numItems = _numItemRepo.GetAllNumItems();
            return Ok(_mapper.Map<IEnumerable<NumItemReadDto>>(numItems));
        }

        [HttpPost]
        public ActionResult CreateNumItem(NumItemCreateDto numItem)
        {
            var mapedNumItem = _mapper.Map<NumItem>(numItem);
            _numItemRepo.CreateNumItem(mapedNumItem);
            _numItemRepo.SaveChanges();

            return CreatedAtRoute("", _mapper.Map<NumItemReadDto>(mapedNumItem));
        }


    }
}
