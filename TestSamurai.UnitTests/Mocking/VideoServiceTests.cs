using Moq;
using TestSamurai.Mocking;

namespace TestSamurai.UnitTests.Mocking
{
    public class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void SetUp()
        {
            _mockFileReader = new Mock<IFileReader>();
            _videoService = new VideoService(_mockFileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _mockFileReader.Setup(m => m.Read("video.txt")).Returns("");

            string? result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
