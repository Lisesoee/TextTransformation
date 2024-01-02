using Microsoft.AspNetCore.Http;
using SpoonerismMicroservice.Services;

namespace TestSpoonerismService
{
    [TestClass]
    public class SpoonerismUnitTests
    {
        [TestMethod]
        public void ApplySpoonerism_SwapsFirstLettersOfTwoWords_Success()
        {
            // Arrange
            SpoonerismService spoonerismService = new SpoonerismService();
            string inputText = "Hello World";

            // Act
            string result = spoonerismService.ApplySpoonerism(inputText);

            // Assert
            Assert.AreEqual("Wello Horld", result);
        }

        [TestMethod]
        public void ApplySpoonerism_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            SpoonerismService spoonerismService = new SpoonerismService();
            string inputText = string.Empty;

            // Act
            string result = spoonerismService.ApplySpoonerism(inputText);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ApplySpoonerism_SingleWordInput_ReturnsSameWord()
        {
            // Arrange
            SpoonerismService spoonerismService = new SpoonerismService();
            string inputText = "Hello";

            // Act
            string result = spoonerismService.ApplySpoonerism(inputText);

            // Assert
            Assert.AreEqual("Hello", result);
        }
    }
}