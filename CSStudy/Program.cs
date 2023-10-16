namespace CSStudy
{
    class QiitaPost : IAuthorQiitaPost, IReaderQiitaPost
    {
        private string m_title;
        private string m_text;

        public QiitaPost(string title, string text)
        {
            this.m_title = title;
            this.m_text = text;
        }
        public string Title => m_title;
        public string Text => m_text;
        public int LGTMCount { get; private set; }
        public int StockCount { get; private set; }
        public void LGTM()
        {
            ++LGTMCount;
        }
        public void Stock()
        {
            ++StockCount;
        }
        public void Delete()
        {
            m_title = string.Empty;
            m_text = string.Empty;
        }
        static void Main(string[] args)
        {
            IAuthorQiitaPost post = new QiitaPost("Title", "Text");
            post.LGTM();
        }
    }
}