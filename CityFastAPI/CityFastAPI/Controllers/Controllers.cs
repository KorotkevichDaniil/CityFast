using CityFastAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityFastAPI.Controllers
{
    public class Controllers : ApiController
    {
        public static CityFastEntities db = new CityFastEntities();

        public Client[] Get()
        {
            return db.Клиенты.ToArray().Select(c => new Client(c)).ToArray();
        }

    }
}
