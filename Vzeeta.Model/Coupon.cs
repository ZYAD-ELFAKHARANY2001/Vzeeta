using System.ComponentModel.DataAnnotations.Schema;
using Vzeeta.Model.Enums;

namespace Vzeeta.Model
{
    public class Coupon:BaseEntity
    {
        public DiscountType DiscountType { get; set; }
        public string? DiscountCode { get; set; }
    }
}