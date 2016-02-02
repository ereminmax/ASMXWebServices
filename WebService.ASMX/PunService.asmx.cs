using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Data;

namespace WebService.ASMX
{
    [WebService(Namespace = "http://puns.org/", Name = "Pun Service v1.0", Description = "This web service provides CRUD functions over a collection of Puns")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class PunService : System.Web.Services.WebService
    {
        [WebMethod]
        public Pun[] GetPuns()
        {
            var service = new PunDataService();
            return service.GetPuns();
        }
    }
}
