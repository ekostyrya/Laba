using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JewelleryClass;

namespace UnitTestProject
{
    [TestClass]
    public class JewelleryBoxTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Jewellery_WhenWeightIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            double WrongWeight = -3;
            double CorrectPrice = 2000;
            string JewelleryModel = "Golden ring";

            //act
            Jewellery golden = new Jewellery(WrongWeight, CorrectPrice, JewelleryModel);
            // assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Jewellery_WhenPriceIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            double CorrectWeight = 15;
            double WrongPrice = -30;
            string JewelleryModel = "Golden ring";

            //act
            Jewellery golden = new Jewellery(CorrectWeight, WrongPrice, JewelleryModel);
            // assert is handled by ExpectedException
        }

       
        [TestMethod]
        public void Purchases_Count()
        {
            // arrange
            Purchases box = new Purchases(new Jewellery(15, 2000, "Golden ring"),
                new Jewellery(23, 3000, "Golden necklace"),
                new Jewellery(15, 5500, "Platinum earrings"));
             
            int expected = 3;
            //act
            int actual = box.Count();

            // assert
            Assert.AreEqual(expected, actual, "Count has not been calculated correctly");
        }


        [TestMethod]
        public void PurchasesCounter_Price()
        {
            // arrange
            Purchases box = new Purchases(new Jewellery(10, 2000, "Golden ring"),
                new Jewellery(20, 6000, "Golden necklace"),
                new Jewellery(15, 5500, "Platinum earrings"));
            PurchasesCounter counter = new PurchasesCounter(box);
            double expected = 222500;
            //act
            double actual = counter.GetTotalPrice();

            // assert
            Assert.AreEqual(expected, actual, 0.001, "TotalPrice has not been calculated correctly");
        }

        [TestMethod]
        public void GiftCalculator_Weight()
        {
            // arrange
            Purchases box = new Purchases(new Jewellery(10, 2000, "Golden ring"),
                new Jewellery(20, 6000, "Golden necklace"),
                new Jewellery(15, 5500, "Platinum earrings"));
            PurchasesCounter counter = new PurchasesCounter(box);
            double expected = 45;
            //act
            double actual = counter.GetTotalWeight();

            // assert
            Assert.AreEqual(expected, actual, 0.001, "TotalWeight has not been not calculated correctly");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Jewellery_WhenJewelleryModelNamelHasName_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            double CorrectWeight = -3;
            double CorrectPrice = 2000;
            string JewelleryModel = "";

            //act
            Jewellery golden = new Jewellery(CorrectWeight, CorrectPrice, JewelleryModel);
            // assert is handled by ExpectedException
                
            
        }
    
    
    }
}

