using Core.Entities;

namespace Entities
{
    public class CustomerDetailDto : IDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

    }
}