using HelpersForUnitTestDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Test
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            var ifade = " Celil Vural ";
            var beklenenIfade = "Celil Vural";
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);
            Assert.AreEqual(beklenenIfade, gerceklesen);
        }
        [TestMethod]
        public void Girilen_ifadenin_icindeki_fazla_bosluklar_silinmelidir()
        {
            var ifade = "Celil  Vural";
            var beklenenIfade = "Celil Vural";
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);
            Assert.AreEqual(beklenenIfade, gerceklesen);
        }
    }
}
