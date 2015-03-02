using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class x64_Tests
    {
        [Fact]
        public void TestA()
        {
            var xUnit_AnyCPU_CLR2_Tests = 1;
            Assert.Equal(xUnit_AnyCPU_CLR2_Tests, 1);
        }
    }
}
