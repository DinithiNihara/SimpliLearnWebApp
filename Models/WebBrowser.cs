using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpliLearnWebApp.Models
{
    public class WebBrowser
    {
        public int Id { get; set; }
        public BrowserName Name { get; set; }
        public int MajorVersion { get; set; }


        public WebBrowser(int id, string name, int majorVersion)
        {
            Id = id;
            Name = TranslateStringToBrowserName(name);
            MajorVersion = majorVersion;
        }

        public WebBrowser()
        {
        }

        private BrowserName TranslateStringToBrowserName(string name)
        {
            if (name.Contains("IE")) return BrowserName.InternetExplorer;
            //TODO: Add more logic for properly sniffing for other browsers.
            return BrowserName.Unknown;
        }

        public enum BrowserName
        {
            Unknown,
            InternetExplorer,
            Edge,
            Firefox,
            Chrome,
            Opera,
            Safari,
            Dolphin,
            Konqueror,
            Linx
        }
    }
}
