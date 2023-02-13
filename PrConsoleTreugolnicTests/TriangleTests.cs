using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrConsoleTreugolnic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PrConsoleTreugolnic.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void MetodTriangle_Negative_Test()
        {
            Triangle triangle = new Triangle();
            triangle.MetodTriangle(-1, -3, -6, -3, -4, -8);
        }
        [TestMethod()]
        public void MetodTriangle_Test_To_Check_Positive_Numbers()
        {
            Triangle triangle = new Triangle();
            triangle.MetodTriangle(1, 3, 6, 3, 4, 8);
        }
        [TestMethod()]
        public void MetodTriangle_Test_To_Check_Positiveand_Negative_Numbers()
        {
            Triangle triangle = new Triangle();
            triangle.MetodTriangle(-1, -3, -6, 3, 4, 8);
        }
        [TestMethod()]
        public void MetodTriangle_Verification_Test_Floating_Point_Numbers()
        {
            Triangle triangle = new Triangle();
            triangle.MetodTriangle(9.6, 2.4, 6.5, 3.6, 4.1, 8.7);
        }
        [TestMethod()]
        public void MetodTriangle_Verification_Test_Negative_Numbers_Floating_Point()
        {
            Triangle triangle = new Triangle();
            triangle.MetodTriangle(-9.6, -2.4, -6.5, -3.6, -4.1, -8.7);
        }
        [TestMethod()]
        public void MetodTriangle_Verification_Test_Floating_Point_Numbers_And_Denial_Floating_Point()
        {
            Triangle triangle = new Triangle();
            triangle.MetodTriangle(9.6, -2.4, 6.5, -3.6, -4.1, 8.7);
        }

    }
}
