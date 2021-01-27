using Microsoft.VisualStudio.TestTools.UnitTesting;
using T21_UNIT_TEST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_UNIT_TEST
{
    [TestClass()]
    public class GeometriaTests
    {
        [TestMethod()]
        public void areacuadradoTest()
        {
            Geometria g = new Geometria();
            int r = g.areacuadrado(2);
            Assert.AreEqual(4, r);
        }

        [TestMethod()]
        public void areaCirculoTest()
        {
            Geometria g = new Geometria();
            double r = g.areaCirculo(4);
            Assert.AreEqual(50.2656, r);
        }

        [TestMethod()]
        public void areatrianguloTest()
        {
            Geometria g = new Geometria();
            int r = g.areatriangulo(2,3);
            Assert.AreEqual(3, r);
        }

        [TestMethod()]
        public void arearectanguloTest()
        {
            Geometria g = new Geometria();
            int r = g.arearectangulo(2, 6);
            Assert.AreEqual(12, r);
        }

        [TestMethod()]
        public void areapentagonoTest()
        {
            Geometria g = new Geometria();
            int r = g.areapentagono(4,5);
            Assert.AreEqual(10, r);
        }

        [TestMethod()]
        public void arearomboTest()
        {
            Geometria g = new Geometria();
            int r = g.arearombo(10,3);
            Assert.AreEqual(15, r);
        }

        [TestMethod()]
        public void arearomboideTest()
        {
            Geometria g = new Geometria();
            int r = g.arearomboide(2,2);
            Assert.AreEqual(4, r);
        }

        [TestMethod()]
        public void areatrapecioTest()
        {
            Geometria g = new Geometria();
            int r = g.areatrapecio(2,3,4);
            Assert.AreEqual(8, r);
        }

        [TestMethod()]
        public void figuraTest()
        {
            Geometria g = new Geometria();
            String r = g.figura(2);
            Assert.AreEqual("Circulo", r);
        }
    }
}