using Gestimonio.Models;

namespace Gestimonio.Repository.SqlServer
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(gestimonio2Context dbContext)
        {
            Trabajadores = new WorkerRepository(dbContext);
            Usuarios = new UsuarioRepository(dbContext);
        }

        public IRepository<TbTrabajador> Trabajadores { get; }

        public IRepository<TbUsuario> Usuarios { get; }
    }
}
