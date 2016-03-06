using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TopshelfNLog
{
    class NancyStartup
    {
        private NancyHost _host;
       
        public void Start()
        {
            var uri = new Uri("http://localhost:3579");
            _host = new NancyHost(uri);
            _host.Start();
            Console.WriteLine("Your application is running on " + uri);
        }

        public void Stop() => _host.Stop();
    }
}
