using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ComtrolHttpTest
{
    public class HttpApi
    {
        //#region sendCommand function for all cmds
        public static string sendCommand(string cmd)
        {
            try
            {
                WebClient mWebClient = new WebClient();
                string retStr = mWebClient.DownloadString(cmd);
                mWebClient.Dispose();
                return retStr;
            }
            catch
            {
                return "";
            }
        }
    }
}
