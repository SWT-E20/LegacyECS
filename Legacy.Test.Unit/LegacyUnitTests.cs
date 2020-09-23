using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

//jenkins test2
namespace Legacy.Test.Unit
{
    [TestFixture]
    public class LegacyUnitTest
    {
        private ECS uut;
        private FakeTempSensor ft;
        private FakeHeater fh;
        [SetUp]
        public void Setup()
        {
            uut = new ECS(20, ft = new FakeTempSensor(), fh = new FakeHeater());
        }

        [TestCase(10)]
        [TestCase(15)]
        [TestCase(20)]
        public void TestGetAndSetThreshHold(int setVal)
        {
            uut.SetThreshold(setVal);
            Assert.That(uut.GetThreshold(), Is.EqualTo(setVal));
        }

        [TestCase(1, 17)]
        [TestCase(2, 18)]
        [TestCase(3, 19)]
        public void Regulate_Temperature_FakeTempTurnOnCorrect(int regTimes, int temp)
        {
            ft.Temp = temp;

            for (int i = 0; i < regTimes; i++)
            {
                uut.Regulate();
            }

            Assert.That(fh.TurnOnCalledTimes, Is.EqualTo(regTimes));
        }

        [TestCase(1, 21)]
        [TestCase(2, 22)]
        [TestCase(3, 23)]
        public void Regulate_Temperature_FakeTempTurnOffCorrect(int regTimes, int temp)
        {
            ft.Temp = temp;

            for (int i = 0; i < regTimes; i++)
            {
                uut.Regulate();
            }

            Assert.That(fh.TurnOffCalledTimes, Is.EqualTo(regTimes));
        }

        [Test]
        public void TestSetTemp()
        {

        }
    }
}
