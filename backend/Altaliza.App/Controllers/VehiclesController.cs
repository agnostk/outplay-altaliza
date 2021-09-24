using System.Collections.Generic;
using System.Linq;
using Altaliza.App.Dtos;
using Altaliza.App.Extensions;
using Altaliza.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Altaliza.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleRepository repository;

        public VehiclesController(IVehicleRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<VehicleDto> GetVehicles()
        {
            var vehicles = repository.GetAll().Select(v => v.AsDto());
            return vehicles;
        }
    }
}