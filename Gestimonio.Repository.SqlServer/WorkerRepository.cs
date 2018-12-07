using Gestimonio.Models;


namespace Gestimonio.Repository.SqlServer
{
    public class WorkerRepository : Repository<TbTrabajador>, IRepository<TbTrabajador>
    {
        public WorkerRepository(gestimonio2Context dbContext) : base(dbContext)
        {
        }
    }
}
