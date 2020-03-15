using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestingMyProject;


namespace TestingMyProject.Test
{
    [TestFixture]
    public class PremiumTests
    {
        
        [Test]
        public static void Test1()
        {                   
            //arrange
            CalculatingPremium p = new CalculatingPremium();
            
            //act    
            float actualResult = p.CalcPremium(18, "urban");        

            //assert
            Assert.That(actualResult, Is.EqualTo(5));         
        }


        [Test]
        public static void Test2()
        {
            //arrange
            CalculatingPremium p = new CalculatingPremium();

            //act    
            float actualResult = p.CalcPremium(31, "urban");

            //assert
            Assert.That(actualResult, Is.EqualTo(2.50f));
        }



        [Test]
        public static void Test3()
        {
            //arrange
            CalculatingPremium p = new CalculatingPremium();

            //act    
            float actualResult = p.CalcPremium(10, "urban");

            //assert
            Assert.That(actualResult, Is.EqualTo(0));
        }



        [Test]
        public static void Test4()
        {
            //arrange
            CalculatingPremium p = new CalculatingPremium();

            //act    
            float actualResult = p.CalcPremium(18, "rural");

            //assert
            Assert.That(actualResult, Is.EqualTo(6));
        }


        [Test]
        public static void Test5()
        {
            //arrange
            CalculatingPremium p = new CalculatingPremium();

            //act    
            float actualResult = p.CalcPremium(36, "rural");

            //assert
            Assert.That(actualResult, Is.EqualTo(5));
        }


        [Test]
        public static void Test6()
        {
            //arrange
            CalculatingPremium p = new CalculatingPremium();

            //act    
            float actualResult = p.CalcPremium(10, "rural");

            //assert
            Assert.That(actualResult, Is.EqualTo(0));
        }


        [Test]
        public static void Test7()
        {
            //arrange
            CalculatingPremium p = new CalculatingPremium();

            //act    
            float actualResult = p.CalcPremium(50, "rural");

            //assert
            Assert.That(actualResult, Is.EqualTo(0.75));
        }


        [Test]
        public static void Test8()
        {
            //arrange
            CalculatingPremium p = new CalculatingPremium();

            //act    
            float actualResult = p.CalcPremium(50, "urban");

            //assert
            Assert.That(actualResult, Is.EqualTo(.375));
        }





    }
}
