namespace Nancy.TopshelfNLog
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get["/"] = _ => 
            {
                var log = NLog.LogManager.GetLogger(nameof(Home));
                log.Info("You called me !!");
                return "Relax , am working just fine";
            };
        }
    }
}
