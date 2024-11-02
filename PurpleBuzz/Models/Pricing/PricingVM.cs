using System;

namespace PurpleBuzz.Models.Pricing;

public class PricingVM
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public ICollection<PricingAdventagesVM> PricingAdventages { get; set; }
}

public class PricingAdventagesVM
{
    public string Title { get; set; }
}
