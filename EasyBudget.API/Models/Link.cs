using System;
using System.Collections.Generic;

namespace EasyBudget.API.Models
{
    /// <summary>
    /// Link. Used for HATEOAS links to related objects.
    /// </summary>
    public class Link
    {
        public string Rel { get; set; }

        public string Href { get; set; }

        public HttpVerb Action { get; set; }

        public ICollection<string> Types { get; set; }

        public Link(string rel, HttpVerb action, string url)
        {
            this.Rel = rel;
            this.Action = action;
            this.Href = url;
            this.Types = new List<string>();
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
