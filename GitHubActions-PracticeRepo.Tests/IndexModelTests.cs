using GitHubActions_PracticeRepo.Pages;
using Xunit;

namespace GitHubActions_PracticeRepo.Tests
{
    public class IndexModelTests
    {
        [Fact]
        public void OnPost_WithValidPlayerChoice_SetsComputerChoiceAndResult()
        {
            // Arrange
            var model = new IndexModel
            {
                PlayerChoice = "グー"
            };

            // Act
            model.OnPost();

            // Assert
            Assert.NotNull(model.ComputerChoice);
            Assert.Contains(model.ComputerChoice, new[] { "グー", "チョキ", "パー" });
            Assert.NotNull(model.Result);
        }
    }
}
