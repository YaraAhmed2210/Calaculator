using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace myCalculator.Tests
{
    [TestClass]
    public class operationsTests
    {
        /*************************** Testing Addition Method  ***************************/

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        //test if any of the inputs is null.
        //but this testcase will never happen in my calculator as 
        //I put 0 by default in the textbox. I wrote it only to show that 
        //we can catch null exceptions too :)
        public void add_null_null_null()  
        {
            var myObj = new operations();
            var result = myObj.add(null, null);
        }

        [TestMethod]
        public void add_pp_p() //addition of two +ve numbers --- expected: +ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = 2;
            double y = 3;
            //Act
            double actual = myObj.add(x, y);
            double expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void add_phigh_n_p() //addition of one big +ve & one -ve --- expected: +ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -2;
            double y = 3;
            //Act
            double actual = myObj.add(x, y);
            double expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void add_nhigh_p_n() //addition of one big -ve & one +ve --- expected: -ve number
        { 
            //Arrange
            operations myObj = new operations();
            double x = -3;
            double y = 2;
            //Act
            double actual = myObj.add(x, y);
            double expected = -1;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void add_nn_n() //addition of two -ve numbers --- expected: -ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -3;
            double y = -2;
            //Act
            double actual = myObj.add(x, y);
            double expected = -5;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        /*************************** Testing Subtraction Method  ***************************/

        [TestMethod]
        public void sub_phigh_p_p() //sub big +ve - +ve --- expected:+ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = 5;
            double y = 2;
            //Act
            double actual = myObj.subtract(x, y);
            double expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void sub_plow_p_n() //sub small +ve - +ve --- expected:-ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = 2;
            double y = 5;
            //Act
            double actual = myObj.subtract(x, y);
            double expected = -3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void sub_np_n() //sub -ve - +ve --- expected: -ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -5;
            double y = 2;
            //Act
            double actual = myObj.subtract(x, y);
            double expected = -7;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void sub_pn_p() //sub +ve - -ve --- expected: +ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = 5;
            double y = -2;
            //Act
            double actual = myObj.subtract(x, y);
            double expected = 7;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void sub_nhigh_n_n() //sub big -ve - -ve --- expected: -ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -5;
            double y = -2;
            //Act
            double actual = myObj.subtract(x, y);
            double expected = -3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void sub_nlow_n_p() //sub small -ve - -ve --- expected: +ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -2;
            double y = -5;
            //Act
            double actual = myObj.subtract(x, y);
            double expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /*************************** Testing Multiplication Method  ***************************/
        [TestMethod]
        public void mul_pp_p() //multiply +ve * +ve  --- expected: +ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = 2;
            double y = 5;
            //Act
            double actual = myObj.multiply(x, y);
            double expected = 10;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void mul_pn_n() //multiply +ve * -ve --- expected: -ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -2;
            double y = 5;
            //Act
            double actual = myObj.multiply(x, y);
            double expected = -10;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void mul_nn_p() //multiply -ve * -ve --- expected: +ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -2;
            double y = -5;
            //Act
            double actual = myObj.multiply(x, y);
            double expected = 10;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /*************************** Testing Division Method  ***************************/

        [TestMethod]
        public void div_pp_p() //divide +ve num by +ve num --- expected: +ve number
        {

            //Arrange
            operations myObj = new operations();
            double x = 5;
            double y = 2;
            //Act
            double actual = myObj.divide(x, y);
            double expected = 2.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void div_np_n() //divide -ve num by +ve num --- expected: -ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -5;
            double y = 2;
            //Act
            double actual = myObj.divide(x, y);
            double expected = -2.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void div_nn_p() //divide -ve num by -ve num --- expected: +ve number
        {
            //Arrange
            operations myObj = new operations();
            double x = -5;
            double y = -2;
            //Act
            double actual = myObj.divide(x, y);
            double expected = 2.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void div_ZERO_Num()  //divide ZERO by any num --- expected: Zero
        {  
            //Arrange
            operations myObj = new operations();
            double x = 0;
            double y = 5;
            //Act
            double actual = myObj.divide(x, y);
            double expected = 0;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void div_by_ZERO_Ex() //divide any num by ZERO --- expected: error msg "can't divide by zero"
        {
            //Arrange
            operations myObj = new operations();
            double x = 5;
            double y = 0;
            //Act
            var result = myObj.divide(x, y);

        }
        




    }
}
