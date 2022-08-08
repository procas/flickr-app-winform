namespace FlickrWFATest
{
    public class PhotoUITest : IDisposable
    {
        private PhotoUIHelper photoUIHelper;
        public PhotoUITest()
        {
            // set up
            photoUIHelper = new PhotoUIHelper();
        }
        [Theory]
        [InlineData("nature")]
        public void Test1(string first)
        {
            string html = photoUIHelper.getHtml(first);
            Assert.NotNull(html);
        }

        [Fact]
        public void Test2()
        {
            string html = photoUIHelper.getHtml("");
            Assert.Equal("<html>No content</html>", html);

        }

        public void Dispose()
        {
            //tear down
        }
    }
}