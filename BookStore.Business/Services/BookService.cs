
using BookStore.Business.Interfaces;
using BookStore.Business.Utils;
using BookStore.Business.ViewModels.BookDTO;
using System.Threading.Tasks;

namespace BookStore.Business.Services
{
    public class BookService : IBookService
    {
        public Task<OperationResult> DisableCollection(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public Task<OperationResult> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<OperationResult> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OperationResult> Insert(BookPostViewModel viewModel)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult Query()
        {
            throw new System.NotImplementedException();
        }

        public Task<OperationResult> Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OperationResult> Update(BookPutViewModel viewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
