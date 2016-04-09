namespace E03.DependencyBreaking
{
    public interface IAppSettingsProvider
    {
        object GetAppSetting(string settingName);
    }
}