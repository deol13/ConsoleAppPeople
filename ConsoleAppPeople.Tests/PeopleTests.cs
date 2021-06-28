using System;
using Xunit;
using ConsoleAppPeople;

namespace ConsoleAppPeople.Tests
{
    public class PeopleTests
    {
        //////////All test runs parallel simultaneously and static remains between test runs.
        [Fact]
        public void IdCounterWorks()
        {
            //Arrange
            string firstName = "Kent";
            string lastName = "Svensson";

            //Act
            int before = Person.Counter;
            new Person(firstName, lastName); //Create person to make counter count up
            int result = Person.Counter;

            //Assert
            Assert.True(before < result);

            Person person1 = new Person(firstName, lastName);
            person1.resetIdCounter();
        }

        [Fact]
        public void PersonIdWorks()
        {
            //Arrange
            string firstName = "Kent";
            string lastName = "Svensson";
            string firstName2 = "Test";
            string lastName2 = "Testsson";

            //Act
            Person person1 = new Person(firstName, lastName);
            Person person2 = new Person(firstName2, lastName2);

            //Assert
            Assert.NotEqual(person1, person2);

        }

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
