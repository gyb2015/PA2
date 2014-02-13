using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.IO;

namespace FinalSub
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "WebApplication1")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Allow this Web Service to be called from script, using ASP.NET AJAX
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<string> GetSearchSuggestions(string input)
        {
            return Global.trie.SearchPhrasesForPrefix(input);
        }
    }
}
