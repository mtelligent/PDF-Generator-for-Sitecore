using Sitecore.Data.Items;
using Sitecore.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SF.Feature.PDF.Extensions
{
    public static class ItemExtensions
    {
        public static string GetFullyQualifiedUrl(this Item item)
        {
            Uri uri = new Uri(System.Web.HttpContext.Current.Request.Url, LinkManager.GetItemUrl(item));
            return uri.ToString();
        }
    }
}