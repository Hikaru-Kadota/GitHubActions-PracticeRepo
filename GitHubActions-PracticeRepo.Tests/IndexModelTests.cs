using GitHubActions_PracticeRepo.Pages;
using Xunit;

namespace GitHubActions_PracticeRepo.Tests
{
    public class IndexModelTests
    {
        [Fact]
        public void OnPost_WithValidPlayerChoice_SetsResult()
        {
            // Arrange
            var model = new IndexModel
            {
                PlayerChoice = "Rock"
            };

            // Act
            model.OnPost();

            // Assert
            Assert.NotNull(model.Result);
        }
    }
}
