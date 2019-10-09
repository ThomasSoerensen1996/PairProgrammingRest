using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicLib;
using PairProgrammingRest;
using PairProgrammingRest.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private MusicsController musik = new MusicsController();

        [TestMethod]
        public void Get()
        {
            Assert.AreEqual("Not Afraid", musik.Get(2).Titel);
        }

        [TestMethod]
        public void GetAll()
        {
            List<Music> tempList = musik.Get().ToList();

            Assert.IsTrue(tempList.Count > 0);
        }

        [TestMethod]
        public void PostAndDelete()
        {
            int orgCount = musik.Get().Count();

            musik.Post(new Music("Titel", "Artist", 3.30, 2018, 4));

            int newCount = musik.Get().Count();

            Assert.AreEqual(newCount, orgCount + 1);

            musik.Delete(4);

            Assert.AreEqual(orgCount, newCount - 1);
        }

        [TestMethod]
        public void Put()
        {
            Music sang = musik.Get(2);

            Assert.AreEqual("Not Afraid", sang.Titel);

            musik.Put(2, new Music("Titel", "Artist", 3.30, 2018, 2));

            Assert.AreEqual("Titel", sang.Titel);
        }
    }
}
