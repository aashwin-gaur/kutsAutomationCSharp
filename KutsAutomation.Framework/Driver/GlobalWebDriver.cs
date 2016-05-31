using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutsAutomation.Framework.Driver


{
    enum element { id,name,css,xp,link,classname};
    class GlobalWebDriver
    {
        public static IWebDriver driver { get; set; }  // for get and set meathod prob tab tab //
    }
}
