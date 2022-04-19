using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityFastAPI.Models
{
    public class Dispatcher
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }

        public Dispatcher(Диспетчеры dis)
        {
            this.Id = dis.idДисп;
            this.FIO = dis.фиоДисп;
            this.Tel = dis.телДисп;
            this.Password = dis.пароль;
        }
    }
}