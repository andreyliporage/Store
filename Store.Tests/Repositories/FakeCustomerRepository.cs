using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string email)
        {
            if (email == "andreydev.io@gmail.com")
                return new Customer("Andrey Liporage", "andreydev.io@gmail.com");

            return null;
        }
    }
}
