using BookStore.Business.Utils;
using BookStore.Business.ViewModels.BookDTO;
using System.Threading.Tasks;

namespace BookStore.Business.Interfaces
{
    public interface IBookService
    {
        Task<OperationResult> FindAll();
        Task<OperationResult> FindById(int id);
        Task<OperationResult> Insert(BookPostViewModel viewModel);
        Task<OperationResult> Update(BookPutViewModel viewModel);
        Task<OperationResult> Remove(int id);
        OperationResult Query();
        Task<OperationResult> DisableCollection(int[] ids);

    }
}
