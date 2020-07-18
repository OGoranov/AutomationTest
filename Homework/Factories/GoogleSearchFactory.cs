using DemoQA.Models;

namespace DemoQA.Factories
{
    public static class GoogleSearchFactory
    {
        public static GoogleSearchModel Create()
        {
            return new GoogleSearchModel
            {
                SearchElement = "selenium",
            };
        }
    }
}
