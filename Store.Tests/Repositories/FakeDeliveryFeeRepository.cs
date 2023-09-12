using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeDeliveryFeeRepository : IDeliveryFeeRepository
    {
        public decimal Get(string zipCode)
        {
            if (zipCode == "2903459")
                return 20;

            return 10;
        }
    }
}
