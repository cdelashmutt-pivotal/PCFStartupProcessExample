namespace SampleSite.Models
{
    public class ChangeQueryResponse
    {
        public string BatchComplete { get; set; }
        public ContinueType Continue { get; set; }
        public RecentQueryResult Query { get; set; }

        public class ContinueType
        {
            public string RcContinue { get; set; }
            public string Continue { get; set; }
        }

        public class RecentQueryResult
        {
            public Change[] RecentChanges { get; set; }
        }

        public class Change
        {
            public string Type { get; set; }
            public string Ns { get; set; }
            public string Title { get; set; }
            public string Pageid { get; set; }
            public string Revid { get; set; }
            public string Oldrevid { get; set; }
            public string Rcid { get; set; }
            public string User { get; set; }
            public string Oldlen { get; set; }
            public string Newlen { get; set; }
        }
    }

}