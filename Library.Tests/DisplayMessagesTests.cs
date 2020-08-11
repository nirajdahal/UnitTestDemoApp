using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Library.Demo;


//Arrange, Act, Assert
//expected
namespace Library.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            //Arrange
            DisplayMessage messages = new DisplayMessage();
            string expected = "Go To Bed Niraj";

            //Act
            string actual = messages.Greeting("Niraj", 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            //Arrange
            DisplayMessage messages = new DisplayMessage();
            string expected = "Good Afternoon Niraj";

            //Act
            string actual = messages.Greeting("Niraj", 14);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Niraj", 0, "Go To Bed Niraj")]
        [InlineData("Niraj", 1, "Go To Bed Niraj")]
        [InlineData("Niraj", 2, "Go To Bed Niraj")]
        [InlineData("Niraj", 3, "Go To Bed Niraj")]
        [InlineData("Niraj", 4, "Go To Bed Niraj")]
        [InlineData("Niraj", 5, "Good Morning Niraj")]
        [InlineData("Niraj", 6, "Good Morning Niraj")]
        [InlineData("Niraj", 7, "Good Morning Niraj")]
        [InlineData("Niraj", 8, "Good Morning Niraj")]
        [InlineData("Niraj", 9, "Good Morning Niraj")]
        [InlineData("Niraj", 10, "Good Morning Niraj")]
        [InlineData("Niraj", 11, "Good Morning Niraj")]
        [InlineData("Niraj", 12, "Good Afternoon Niraj")]
        [InlineData("Niraj", 13, "Good Afternoon Niraj")]
        [InlineData("Niraj", 14, "Good Afternoon Niraj")]
        public void GreetingsShouldReturnExpectedValue(string firstName, int hourOfTheDay, string expected)
        {
            //Arrange
            DisplayMessage messages = new DisplayMessage();
            

            //Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
