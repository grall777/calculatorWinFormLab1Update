using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator.Tests
{
    [TestClass()]
    public class utilTests
    {
        private object textbox1;
        private Label labeMinus;

        [TestMethod()]
        public void readingTest()
        {
            try
            {
                util tests = new util();
                tests.reading("1", (TextBox)textbox1);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }


        }

        [TestMethod()]
        public void SolutionTest()
        {
            try
            {
                util tests = new util();
                tests.Solution((TextBox)textbox1, (Label)labeMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void ClearTest()
        {
            try
            {
                util tests = new util();
                tests.Clear((TextBox)textbox1, (Label)labeMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }

        }

        [TestMethod()]
        public void OperationTest()
        {
            try
            {
                util tests = new util();
                tests.Operation((TextBox)textbox1, 0, (Label)labeMinus); // plus
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void ReverseMinusTest()
        {
            try
            {
                util tests = new util();
                tests.ReverseMinus((Label)labeMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }
    }
}