using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFesta.TestModel
{
    public class SalgadoModelTest
    {
        [Fact]
        public void TestForIntanceOfSalgadoModel()
        {
            //Arrange
            Salgado salgado;
            //Act
            salgado = new Salgado();
            //Assent
            Assert.IsType<Salgado>(salgado);
        }

        [Fact]
        public void TestForHeritageToSalgadoOfBase()
        {
            //Arrange
            Type salgado = typeof(Salgado);
            Type basetype = typeof(BaseModel);
            //Act
            bool model = salgado.IsSubclassOf(basetype);
            //Assent
            Assert.True(model);
        }
        [Fact]
        public void TestForHeritageToSalgadoOfBase2()
        {
            //Arrange
            Salgado salgado;
            //Act
            salgado = new Salgado();
            //Assent
            Assert.IsAssignableFrom<BaseModel>(salgado);
        }
        [Fact]
        public void TestIdOfSalgado()
        {
            //Arrange
            Salgado salgado;
            int id = 1;
            //Act
            salgado = new Salgado();
            salgado.Id = id;
            //Assert
            Assert.Equal(id, salgado.Id);
        }
        [Fact]
        public void TestNameOfSalgado()
        {
            //Arrange
            Salgado salgado;
            string name = "Coxinha";
            //Act
            salgado = new Salgado();
            salgado.Nome = name;
            //Assert
            Assert.Equal(name, salgado.Nome);
        }
        [Fact]
        public void TestingSalgadosTaste()
        {
            //Arrange
            Salgado salgado;
            string taste = "Carne";
            //Act
            salgado = new Salgado();
            salgado.Sabor = taste;
            //Assert
            Assert.Equal(taste, salgado.Sabor);
        }
    }
}
