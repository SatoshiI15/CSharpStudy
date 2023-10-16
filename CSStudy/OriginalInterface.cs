using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStudy
{
    interface IQiitaPost
    {
        int LGTMCount { get; }
        int StockCount { get; }
    }
    interface IAuthorQiitaPost : IQiitaPost
    {
        void Delete();
    }
    interface IReaderQiitaPost : IQiitaPost
    {
        string Title { get; }
        string Text { get; }
        void LGTM();
        void Stock();
    }
}
