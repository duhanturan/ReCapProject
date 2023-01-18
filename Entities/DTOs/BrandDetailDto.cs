using Core.Entities;

namespace Entities
{
    public class BrandDetailDto:IDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}