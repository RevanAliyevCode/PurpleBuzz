using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurpleBuzz.Entities;

[Table("pricing")]
public class Pricing : BaseEntity
{
    [Column("title")]
    public string Title { get; set; }
    [Column("price")]
    public decimal Price { get; set; }
    public ICollection<PricingAdventages> PricingAdventages { get; set; }
}

[Table("pricing_adventages")]
public class PricingAdventages : BaseEntity
{
    [Column("pricing_id")]
    public int PricingId { get; set; }
    [Column("title")]
    public string Title { get; set; }
}
