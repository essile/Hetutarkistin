using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hetutarkistin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hetutarkistin.Tests
{
    [TestClass()]
    public class TarkistaHenkilotunnusTests
    {
        [TestMethod()]
        public void OkHetuTest()
        {            
            string hetu = "121288-1233";
            string virheilmoitus = "test";
            bool expected = true;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän pitäis toimia.");
        }

        [TestMethod()]
        public void OkHetuPienellaTarkistekirjaimellaTest()
        {
            string hetu = "121288-132c";
            string virheilmoitus = "test";
            bool expected = true;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän pitäis toimia.");
        }

        [TestMethod()]
        public void VaaraViimeinenMerkkiTest()
        {
            string hetu = "121288-1234";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, väärä tarkistemerkki.");
        }

        [TestMethod()]
        public void HetuMinimiarvoillaTest()
        {
            string hetu = "000150-000P";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, pelkkiä nollia.");
        }

        [TestMethod()]
        public void LiianLyhytTest()
        {
            string hetu = "121288-123";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, liian lyhyt.");
        }

        [TestMethod()]
        public void KirjainSyntymaAjassaTest()
        {
            string hetu = "1212P8-1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, kirjain syntymäajassa.");
        }

        [TestMethod()]
        public void KirjainSyntymanumerossaTest()
        {
            string hetu = "121288-12U3";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, kirjain syntymänumerossa.");
        }

        [TestMethod()]
        public void LiianIsoPPTest()
        {
            string hetu = "321288-1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, päivä 32.");
        }

        [TestMethod()]
        public void LiianIsoKKTest()
        {
            string hetu = "121388-1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, kuukausi 13.");
        }

        [TestMethod()]
        public void VuosiTulevaisuudessaTest()
        {
            string hetu = "121225A1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, ei voi olla syntynyt tulevaisuudessa.");
        }

        [TestMethod()]
        public void Yli115VuotiasTest()
        {
            string hetu = "121201-1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, liian vanha.");
        }

        [TestMethod()]
        public void _1800LukuTest()
        {
            string hetu = "121288+1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, 1800-luvulta.");
        }

        [TestMethod()]
        public void ValimerkkiaEiOlemassa()
        {
            string hetu = "121288:1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Tän ei pitäis toimia, : ei ole välimerkki.");
        }

        [TestMethod()]
        public void EiKarkausvuosiTest()
        {
            string hetu = "290293-1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Ei pitäis toimia, karkausvuosi.");
        }

        [TestMethod()]
        public void KarkauspaivaTest()
        {
            string hetu = "290292-1231";
            string virheilmoitus = "test";
            bool expected = true;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Pitäis toimia, karkausvuosi.");
        }

        [TestMethod()]
        public void LiianIsoPPHuhtikuuTest()
        {
            string hetu = "310493-1233";
            string virheilmoitus = "test";
            bool expected = false;
            bool actual = TarkistaHenkilotunnus.TarkistaHetu(hetu, out virheilmoitus);
            Assert.AreEqual(expected, actual, "Ei pitäis toimia, huhtikuu=30pv.");
        }

    }
}