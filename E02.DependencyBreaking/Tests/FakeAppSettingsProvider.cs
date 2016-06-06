
namespace E03.DependencyBreaking.Tests
{
    class FakeAppSettingsProvider : IAppSettingsProvider
    {
        public double Discount { get; set; }
        public double DiscountTreshold { get; set; }

        public FakeAppSettingsProvider(double discount = 0,double discountTreshold = 0)
        {
            Discount = discount;
            DiscountTreshold = DiscountTreshold;
        }

        public object GetAppSetting(string settingName)
        {
            if (settingName.Contains("DiscountTreshold"))
            {
                return DiscountTreshold;
            }
            else
            {
                if (settingName.Contains("Discount"))
                {
                    return Discount;
                }
                else
                {
                    return null;
                }
            }
            
        }
    }
}
