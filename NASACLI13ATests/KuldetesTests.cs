using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASACLI13A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLI13A.Tests
{
    [TestClass()]
    public class KuldetesTests
    {
        [TestMethod()]
        [DataRow(25,1000000, "Magas")]
        [DataRow(25,100, "Közepes")]
        [DataRow(0.8,1000000, "Közepes")]
        [DataRow(0.5,10, "Alacsony")]
        public void KockazatiSzintTest(double koltseg, double hasznosteher, string elvart)
        {
            	//"Magas" ha a költség meghaladja az 1 milliárd USD-t és a rakomány tömege több mint 10 tonna.
	            //"Közepes" ha csak az egyik feltétel teljesül.
	            //"Alacsony" ha egyik feltétel sem teljesül.

            Kuldetes magas = new Kuldetes($"Apollo 11;1969;Hold;3;Igen;Első emberes holdraszállás;{koltseg};{hasznosteher}");
            string aktualis = magas.KockazatiSzint();
            Assert.AreEqual(elvart, aktualis);
        }
    }
}