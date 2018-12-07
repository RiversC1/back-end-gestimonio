using Gestimonio.Models;

namespace Gestimonio.Repository.SqlServer
{
    public class UsuarioRepository : Repository<TbUsuario>, IRepository<TbUsuario>
    {
        public UsuarioRepository(gestimonio2Context dbContext) : base(dbContext)
        {
        }
    }
}
