using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackStage.Models
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString Span(this HtmlHelper Helper, string Content, string Class = "")
        {
            string classstring = Class == "" ? "" : string.Format(" class=\"{0}\" ", Class);
            string htmlString = String.Format("<span{1}>{0}</span>", Content, classstring);
            return new HtmlString(htmlString);
        }
    }
}