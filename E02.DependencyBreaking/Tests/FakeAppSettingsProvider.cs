
namespace E03.DependencyBreaking.Tests
{
    class FakeAppSettingsProvider : IAppSettingsProvider
    {
        public object GetAppSetting(string settingName)
        {

            if (settingName.Equals("Discount")){
                return 0.01;
            } else
            {
                if (settingName.Equals("DiscountTreshold"))
                {
                    return 1.0;
                }else
                {
                    return null;
                }
            }
        }
    }
}
