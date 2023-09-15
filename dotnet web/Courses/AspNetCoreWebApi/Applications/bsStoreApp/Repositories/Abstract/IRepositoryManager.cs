namespace Repositories.Abstract
{
    public interface IRepositoryManager
    {
        IBookRepository BookRepository { get; }
        void Save();
    }
}
