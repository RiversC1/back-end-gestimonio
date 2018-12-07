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
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public UserController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_unit.Usuarios.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Usuarios.GetList());
        }

        [HttpPost]
        public int Add(TbUsuario usuario)
        {
            return _unit.Usuarios.Add(usuario);
        }

        [HttpPut]
        public bool Update(TbUsuario usuario)
        {
            return _unit.Usuarios.Update(usuario);
        }

        [HttpDelete]
        public bool Delete(TbUsuario usuario)
        {
            return _unit.Usuarios.Delete(usuario);
        }

    }
}