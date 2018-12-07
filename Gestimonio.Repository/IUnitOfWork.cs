using Gestimonio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestimonio.Repository
{
    public interface IUnitOfWork
    {
        IRepository<TbTrabajador> Trabajadores { get; }
        IRepository<TbUsuario> Usuarios { get; }
    }
}
