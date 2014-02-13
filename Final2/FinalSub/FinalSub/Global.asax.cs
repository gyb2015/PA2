using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using FinalSub;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        public static Trie trie;

        protected void Application_Start(object sender, EventArgs e)
        {
            // Build a Trie when web app starts
            trie = new Trie();

            using (StreamReader sr = new StreamReader(Server.MapPath("enwiki-20131104-all-titles-in-ns0-preprocessed")))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();

                    try
                    {
                        trie.InsertPhrase(line);
                    }
                    catch (OutOfMemoryException)
                    {
                        break;
                    }
                }
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}