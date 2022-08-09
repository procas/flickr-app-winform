using FlickrWFA.Interfaces;
using FlickrWFATest.Resources;

namespace FlickrWFATest
{
    public class PhotoUITest : IDisposable
    {
        private PhotoUIHelper photoUIHelper;
        private Resource resource;
        public PhotoUITest()
        {
            // set up
            photoUIHelper = new PhotoUIHelper();
            resource = new();
            
        }
        [Theory]
        [InlineData("nature")]
        public void Should_NotNull(string first)
        {
            string html = photoUIHelper.getHtml(first);
            Assert.NotNull(html);
        }

        [Fact]
        public void Should_DefaultValue()
        {
            string html = photoUIHelper.getHtml("");
            Assert.Equal("<html>No content</html>", html);

        }
        [Fact]
        public void UI_TDD()
        {
            var mock = new Mock<IView>();
            mock
    .Setup(x => x.htmlString)
    .Returns(resource.testHTML);
        }

        public void Dispose()
        {
            //tear down
        }
    }
}