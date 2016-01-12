using System;

namespace NancyShadowAssemblies {
    class Program {
        static int Main( string[] args ) {
            AppDomainSetup setup = new AppDomainSetup {
                ShadowCopyFiles = "true" // This is key
            };            

            var domain = AppDomain.CreateDomain( "Real AppDomain", null, setup );

            // Execute your real application in the new app domain
            int result = domain.ExecuteAssembly(
                "NancyShadowAssemblies.Implementation.exe",
                args
            );

            return result;
        }
    }
}
