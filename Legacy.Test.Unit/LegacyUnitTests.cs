using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Legacy;
using NSubstitute;
using NUnit.Framework;


//jenkins test2
namespace Legacy
{
    [TestFixture]
    public class LegacyUnitTest
    {
        private ECS _uut;
        private ITempSensor _tempSensor;
        private IHeater _heater;

        [SetUp]
        public void SetUp()
        {
            _heater = Substitute.For<IHeater>();
            _tempSensor = Substitute.For<ITempSensor>();

            _uut = new ECS(25, _tempSensor, _heater);
        }

        //[Test]
        //public void GetTempTest()
        //{
        //    int temp = _tempSensor.GetTemp();
        //    Assert.AreEqual(25, 25);
        //}


    }


}


//    public void TestGetAndSetThreshHold(int setVal)
        //{
       
        //public void Regulate_Temperature_FakeTempTurnOnCorrect(int regTimes, int temp)
        //{
     
        //}

     
        //public void Regulate_Temperature_FakeTempTurnOffCorrect(int regTimes, int temp)
        //{
  
        //}

   
        //public void GetCurTemp_TestSetTemp_CorrectTemp(int temp)
        //{
     
