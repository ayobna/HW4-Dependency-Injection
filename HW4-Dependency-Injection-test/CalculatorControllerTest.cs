using HW4_Dependency_Injection.Controllers;
using HW4_Dependency_Injection.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HW4_Dependency_Injection_test
{
    [TestClass]
    public class CalculatorControllerTest
    {
        [DataRow( 100, 40, 140)]
        [DataRow(10, 40, 50)]
        [DataTestMethod]
        public void CalculatorResult_ReturnResultSumOfTwoNumbers_SumResult(int num1,int num2,int result)
        {
            Mock<ICalculator> chk = new Mock<ICalculator>();
          chk.Setup(m => m.Add(num1, num2)).Returns(num1+num2);
            CalculatorController cc = new CalculatorController(chk.Object);
            Assert.AreEqual(result, cc.CalculatorResult(num1,num2));
        }
    }
}
