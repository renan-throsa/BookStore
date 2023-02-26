using BookStore.Business.Interfaces;
using BookStore.Business.Utils;
using BookStore.Business.ViewModels.CustomerDTO;
using System;
using System.Threading.Tasks;

namespace BookStore.Business.Services
{
    public class CustomerService : ICustomerService
    {
        public Task<OperationResult> DisableCollection(int[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Insert(CustomerPostViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public OperationResult Query()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Update(CustomerPutViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
