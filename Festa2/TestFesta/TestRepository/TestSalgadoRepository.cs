using Data.Model;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFesta.TestRepository
{
    public class TestSalgadoRepository
    {
        [Fact]
        public void TestingIntance()
        {
            //Arrange
            SalgadoRepository salgado;
            //Act
            salgado = new SalgadoRepository();
            //Assert
            Assert.IsType<SalgadoRepository>(salgado);
        }
        [Fact]
        public void TestingCreationMethod()
        {
            //Arrange
            SalgadoRepository repor;
            Salgado salgado;
            int id = 0;
            //Act
            repor = new SalgadoRepository();
            salgado = new Salgado();
            salgado.Nome = "test";
            salgado.Sabor = "Carne";
            repor.Create(salgado);
            //Assert
            Assert.NotEqual(id, salgado.Id);
        }
        [Fact]
        public void TestingReadMethod()
        {
            //Arrange
            //Act
            //Assent
        }
    }
}
