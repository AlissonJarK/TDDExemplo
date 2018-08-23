using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FooBaa.teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Múltiplo3RetornaFoo()
        {
            int número = 3;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter();
            Assert.AreEqual("Foo",result);
        }

        [TestMethod]
        public void Múltiplo5RetornaBaa()
        {
            int número = 5;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter();
            Assert.AreEqual("Baa", result);
        }

        [TestMethod]
        public void Múltiplo3e5RetornaFooBaa()
        {
            int número = 15;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter();
            Assert.AreEqual("FooBaa", result);
        }

        [TestMethod]
        public void MúltiploDeNenhumDosDoisRetornaNada()
        {
            int número = 11;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter();
            Assert.AreEqual("", result);
        }
    }
}
