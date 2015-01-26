using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xunit20Tests_AnyCPU
{
    public class AnyCPU_Tests
    {
        [Fact]
        [Trait("CI", "skip")]
        public void TestA()
        {
            var xUnit_AnyCPU_CLR2_Tests = 1;
            Assert.Equal(xUnit_AnyCPU_CLR2_Tests, 1);
        }
        
        [Fact]
        public void TestB()
        {
            var xUnit_AnyCPU_CLR2_Tests = 1;
            Assert.Equal(xUnit_AnyCPU_CLR2_Tests, 1);
        }        
    }
}
