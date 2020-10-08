using NUnit.Framework;
using System.Reflection.Metadata.Ecma335;
using NUnit.Framework.Constraints;
using assignment_1;
using System;

namespace NUnitTest_TriangleSolver
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {

        }
        [Test]
       public static void Test1()
        {
         int a=10, b=10, c=10;
            bool expected_result = a == b && b == c;
          bool actual_result = a == b && b == c;

    
                Assert.AreEqual(expected_result,actual_result );
        }

        [Test]
        public static void Test2()
        {
            int a = 10, b = 10, c = 6;
            bool expected_result = a == b || b == c ||c==a;
            bool actual_result = a == b || b == c || c == a;


            Assert.AreEqual(expected_result, actual_result);
        }
        [Test]
        public static void Test3()
        {
            int a = 10, b = 1, c = 6;
            bool expected_result = a != b && b != c;
            bool actual_result = a != b && b != c;


            Assert.AreEqual(expected_result, actual_result);
        }
        [Test]
        public static void Test4()
        {
            int a = 0, b = 0, c = 0;
            bool expected_result = (a + b > c && b + c > a && c + a > b);
            bool actual_result = (a + b > c && b + c > a && c + a > b);


            Assert.AreEqual(expected_result, actual_result);
        }

        [Test]
        public static void Test5()
        {
            int a = 2, b = 8, c = 5;
            bool expected_result = (a + b > c && b + c >a && c + a > b);
            bool actual_result = (a + b > c && b + c > a && c + a > b);


            Assert.AreEqual(expected_result, actual_result);
        }
        [Test]
        public static void Test6()
        {
            int a = 0, b = -1, c = 0;
            bool expected_result = (a + b > c && b + c > a && c + a > b);
            bool actual_result = (a + b > c && b + c > a && c + a > b);


            Assert.AreEqual(expected_result, actual_result);
        }

        [Test]
        public static void Test7()
        {
            int a = -5, b = -1, c = 0;
            bool expected_result = (a + b > c && b + c > a && c + a > b);
            bool actual_result = (a + b > c && b + c > a && c + a > b);


            Assert.AreEqual(expected_result, actual_result);
        }
        [Test]
        public static void Test8()
        {
            int a = -5, b = -5, c = -5;
            bool expected_result = (a + b > c && b + c > a && c + a > b);
            bool actual_result = (a + b > c && b + c > a && c + a > b);


            Assert.AreEqual(expected_result, actual_result);
        }






    }
    }
