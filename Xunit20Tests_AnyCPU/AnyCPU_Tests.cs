using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xunit20Tests_AnyCPU
{
    public class Tests
    {
        [Fact]
        [Trait("CI", "skip")]
        public void TestA()
        {
            var xUnit_AnyCPU_CLR2_Tests = 1;
            Assert.Equal(xUnit_AnyCPU_CLR2_Tests, 1);
            Debug.WriteLine("Debug output");
            Console.WriteLine("Console output");
            Trace.TraceInformation("Trace info");            
        }
        
        [Fact]
        public void TestB()
        {
            var xUnit_AnyCPU_CLR2_Tests = 1;
            Assert.Equal(xUnit_AnyCPU_CLR2_Tests, 1);
        }

        [Fact]
        public void Test_should_access_config()
        {
            // appSettings
            var someValue = ConfigurationManager.AppSettings["SomeValue"];
            Console.WriteLine("SomeValue: " + someValue);
            Assert.Equal("Hello, config!", someValue);

            // connectionStrings
            var connString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Console.WriteLine("MyConnectionString: " + connString);
            Assert.Equal("Server=(local);user=John", connString);
        }
    }
}
