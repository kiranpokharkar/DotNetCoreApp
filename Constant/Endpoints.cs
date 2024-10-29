using System.Net.Http.Headers;

namespace Demo.Constant
{
    public class Endpoints
    {
        public class Products
        {
            private const string Version = "";

            private const string Base = "https://dummyjson.com/";

            private const string Controller = "products";

            public const string Get =  Base + Version + Controller;
        }

        public class ApiRoutes
        {
            private const string Route = "api";

            private const string Version = "v1";

            public const string path = Route + "/" + Version;

            public static class Product
            {
                private const string Base = path + "/" + "products";

                public const string Get = Base; 
            }
        }
    }
}
