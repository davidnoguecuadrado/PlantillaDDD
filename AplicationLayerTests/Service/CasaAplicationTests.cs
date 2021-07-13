using System;
using System.Collections.Generic;
using AplicationLayer.Inteface;
using Autofac.Extras.Moq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AplicationLayerTests.Service
{
    [TestClass()]
    public class CasaAplicationTests
    {
        
        private Mock<ICasaAplication> mock;
        private Casa casa;
        [TestInitialize]
        public void Setup()
        {
            var autoMock = AutoMock.GetLoose();
            mock = autoMock.Mock<ICasaAplication>();

            casa = new Casa();
            casa.CompradorID= 1;

            mock.Setup(service => service.AddCasa(It.IsAny<Casa>())).Returns((Casa casa) => casa);
            mock.Setup(service => service.AddCasa(null)).Throws(new NullReferenceException());
            mock.Setup(service => service.UpdateCasa(casa)).Returns(casa);
            mock.Setup(service => service.DeleteCasa(It.IsAny<Casa>())).Returns(It.IsAny<Casa>());
            mock.Setup(service => service.GetCasa()).Returns(It.IsAny<List<Casa>>());
            mock.Setup(service => service.GetCasa(It.IsAny<int>())).Returns(It.IsAny<Casa>());

        }


        [TestMethod()]
        public void AddCasaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteCasaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCasaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCasaTestUno()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateCasaTest()
        {
            Assert.Fail();
        }
    }
}
