﻿using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

//jenkins test2
namespace Legacy.Test.Unit
{
    [TestFixture]
    public class LegacyUnitTest
    {
        private ECS uut;
        [SetUp]
        public void Setup()
        {
            uut = new ECS(20, new FakeTempSensor(), new FakeHeater());
        }

        [TestCase(10, 10)]
        [TestCase(15, 15)]
        [TestCase(20, 20)]
        [TestCase(25, 25)]

        public void TestGetThreshHold(int threshold, int val)
        {
            uut.SetThreshold(threshold);
            val = uut.GetThreshold();
            Assert.That(threshold, Is.EqualTo(val));
        }

        [Test]
        public void TestSetTemp()
        {

        }
    }
}
