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
            int num = 3;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter(num);
            Assert.AreEqual("Foo",result);
        }

        [TestMethod]
        public void Múltiplo5RetornaBaa()
        {
            int num = 5;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter(num);
            Assert.AreEqual("Baa", result);
        }

        [TestMethod]
        public void Múltiplo3e5RetornaFooBaa()
        {
            int num = 15;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter(num);
            Assert.AreEqual("FooBaa", result);
        }

        [TestMethod]
        public void MúltiploDeNenhumDosDoisRetornaNada()
        {
            int num = 11;
            ConversorFooBaa cfb = new ConversorFooBaa();
            string result = cfb.Converter(num);
            Assert.AreEqual("", result);
        }
    }
}
