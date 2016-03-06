namespace Nancy.TopshelfNLog
{
    
    using global::Topshelf;

    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x => {
                x.Service<NancyStartup>(service => {
                    service.ConstructUsing(name => new NancyStartup());
                    service.WhenStarted(start => start.Start());
                    service.WhenStopped(stop => stop.Stop());
                });

                x.UseNLog();
                x.RunAsLocalSystem();
                x.SetDescription("Nancy self host");
                x.SetServiceName("Nancy-Api");
            });
          
        }
    }
}
