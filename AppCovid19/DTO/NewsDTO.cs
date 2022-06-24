namespace AppCovid19.DTO
{
    public class NewsDTO
    {
        public class News
        {
            public string Title { get; set; }
            public string Url { get; set; }
            public string CreateTime { get; set; }
        }

        public class NewsDetail
        {
            public string Title { get; set; }
            public string Content { get; set; }
        }
    }
}