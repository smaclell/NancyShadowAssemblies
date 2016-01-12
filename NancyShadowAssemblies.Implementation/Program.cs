using System;

using Nancy;
using Nancy.Hosting.Self;

namespace NancyShadowAssemblies.Implementation {
    class Program {
        static void Main( string[] args ) {
            var url = new Uri( "http://localhost:12345" );
            using ( var host = new NancyHost( new DefaultNancyBootstrapper(), url ) ) {
                host.Start();

                Console.WriteLine( "Now listening, have fun!" );

                Console.ReadLine();
            }
        }
    }
}
