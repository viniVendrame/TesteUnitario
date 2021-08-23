using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFesta
{
    public class BaseModelTest
    {
        [Fact]
        public void TestToTheBaseModelInstance()
        {
            //Arrange
            Action BaseAction;
            //Act
            BaseAction = () => Activator.CreateInstance<BaseModel>();
            //Assert
            Assert.Throws<MissingMethodException>(BaseAction);
        }
    }
}
