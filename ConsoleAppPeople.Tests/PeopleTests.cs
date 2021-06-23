using System;
using Xunit;
using ConsoleAppPeople;

namespace ConsoleAppPeople.Tests
{
    public class PeopleTests
    {
        [Fact]
        public void DetailsContainsCorrectInfo()
        {
            //Arrange
            string firstName = "Kent";
            string lastName = "Svensson";
            int age = 42;
            Gender gender = Gender.Male;
            bool isVaccinated = true;
            string expectedVaccinated = "Yes";
            Person testPerson = new Person(firstName, lastName, age, gender, isVaccinated);

            //Act
            string result = testPerson.Details();

            //Assert
            Assert.Contains(firstName, result);
            Assert.Contains(lastName, result);
            Assert.Contains(age.ToString(), result);
            Assert.Contains(gender.ToString(), result);
            Assert.Contains(expectedVaccinated, result);
        }
    }
}
