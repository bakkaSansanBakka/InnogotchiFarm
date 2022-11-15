using InnogotchiFarm.Contracts;

namespace InnogotchiFarm.Data
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
