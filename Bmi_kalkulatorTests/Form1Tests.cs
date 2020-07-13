using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bmi_kalkulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmi_kalkulator.Tests
{
    [TestClass()]
    public class Form1Tests : Form1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            Kalkulator bm = new Kalkulator();
            double res = bm.Dodawanie(10, 10);
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            Kalkulator bm = new Kalkulator();
            double res = bm.Odejmowanie(10, 10);
            Assert.AreEqual(res, 0);
        }

    }

}



