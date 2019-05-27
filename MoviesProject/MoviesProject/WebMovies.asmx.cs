using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace MoviesProject
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebMovies : System.Web.Services.WebService
    {
        [WebMethod]
        public void GetAllMovies()
        {
            try
            {
                Logger.WriteLog("Client Requested GetAllMovies", EventLogEntryType.Information);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Write(js.Serialize(MovieGenerator.Movies));
                Logger.WriteLog("GetAllMovies Recived and Serialized and sent", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, EventLogEntryType.Error);
            }
            
        }
        [WebMethod]
        public void GetMovie(int id)
        {
            try
            {
                Logger.WriteLog("Client Requested " + MovieGenerator.Movies[id].Title, EventLogEntryType.Information);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Write(js.Serialize(MovieGenerator.Movies[id]));
                Logger.WriteLog(MovieGenerator.Movies[id].Title + " Recived and Serialized and sent", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, EventLogEntryType.Error);
            }
            
        }
    }
}
