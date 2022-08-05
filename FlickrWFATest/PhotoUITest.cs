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
            List<string> urlList = photoUIHelper.getUrlList(first);
            Assert.NotNull(urlList);
        }

        [Fact]
        public void Test2()
        {
            List<string> urlList = photoUIHelper.getUrlList("");
            Assert.Empty(urlList);

        }

        public void Dispose()
        {
            //tear down
        }
    }
}