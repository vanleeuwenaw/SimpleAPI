using System;
using Xunit;
using System.Windows;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get(1);
            
            Assert.Equal("value2", returnValue.Value);
            
            
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
