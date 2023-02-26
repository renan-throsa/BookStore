using BookStore.Business.Utils;
using BookStore.Business.ViewModels.BookDTO;
using BookStore.Business.ViewModels.CustomerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Interfaces
{
    public interface ICustomerService
    {
        Task<OperationResult> FindAll();
        Task<OperationResult> FindById(int id);
        Task<OperationResult> Insert(CustomerPostViewModel viewModel);
        Task<OperationResult> Update(CustomerPutViewModel viewModel);
        Task<OperationResult> Remove(int id);
        OperationResult Query();
        Task<OperationResult> DisableCollection(int[] ids);
    }
}
