using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_batch9.CustomHelpers
{
    public static  class UserHelperControl
    {
        public static IHtmlString MyLabel(string content)
        {
            string htmlstring = String.Format("<label>{0}</label>", content);
            return new HtmlString(htmlstring);
        }


    }
}