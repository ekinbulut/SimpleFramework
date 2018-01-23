namespace SimpleFramework.Core
{
    public static class BootManager
    {
        public static void Startup()
        {
            IoCManager.Manager.Build();
        }
    }
}
