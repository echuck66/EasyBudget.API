using System;
namespace EasyBudget.API.Models
{
    public class Link
    {
        public string rel { get; set; }

        public HttpVerb verb { get; set; }

        public string href { get; set; }

        public Link(string related, HttpVerb verb, string url)
        {
            this.rel = related;
            this.verb = verb;
            this.href = url;
        }
    }

    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
