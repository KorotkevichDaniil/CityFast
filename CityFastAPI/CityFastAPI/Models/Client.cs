using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityFastAPI.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }

        public Client(Клиенты cl)
        {
            this.Id = cl.idКл;
            this.FIO = cl.фиоКл;
            this.Tel = cl.телКл;
            this.Password = cl.пароль;
        }
    }
}