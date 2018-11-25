using System;
using System.Security.Authentication;
using AutoFixture;
using Moq;
using OOP_lesson_series.Lesson_1._Classes_and_scope;
using Xunit;

namespace LessonTests
{
    public class BabyTest
    {
        [Fact]
        public void FutureBabyTest()
        {
            Assert.Throws<FutureBabyException>(() => new Baby("Big Tom", new DateTime(2019, 5, 15)));
        }

        [Fact]
        public void BabyTooOldTest()
        {
            Assert.Throws<BabyTooOldException>(() => new Baby("Big Tom", new DateTime(2005, 5, 15)));
        }

        [Theory]
        [ClassData(typeof(BabyDataFutureBabiesTest))]
        public void FutureBabyTestMultiClass(int year, int month, int day)
        {
            Assert.Throws<FutureBabyException>(() => new Baby("Big Tom", new DateTime(year, month, day)));
        }

        [Theory]
        [InlineData(2018, 11, 26)]
        [InlineData(9999, 05, 4)]
        public void FutureBabyTestMultiLine(int year, int month, int day)
        {
            Assert.Throws<FutureBabyException>(() => new Baby("Big Tom", new DateTime(year, month, day)));
        }

        [Theory]
        [InlineData(int.MaxValue, int.MaxValue, int.MaxValue)]
        public void BadDateMultiLine(int year, int month, int day)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Baby("Big Tom", new DateTime(year, month, day)));
        }

        [Fact]
        public void TestPopulate()
        {
            //Arrange
            var fixture = new Fixture();
            Baby dummyBaby = fixture.Create<Baby>();
            //Act

            //Assert
            Assert.NotNull(dummyBaby.Birthday);
            Assert.NotNull(dummyBaby.Name);
        }

    }
}
