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
        [Fact]
        public void Test1()
        {
            photoUIHelper.getUrlList("nature");
        }
        public void Dispose()
        {
            //tear down
        }
    }
}