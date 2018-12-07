using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestimonio.Models;
using Gestimonio.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestimonio.WebApi.Controllers
{
    [Route("api/worker")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public WorkerController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_unit.Trabajadores.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Trabajadores.GetList());
        }

        [HttpPost]
        public int Add(TbTrabajador trabajador)
        {
            return _unit.Trabajadores.Add(trabajador);
        }

        [HttpPut]
        public bool Update(TbTrabajador trabajador)
        {
            return _unit.Trabajadores.Update(trabajador);
        }

        [HttpDelete]
        public bool Delete(TbTrabajador trabajador)
        {
            return _unit.Trabajadores.Delete(trabajador);
        }
    }
}