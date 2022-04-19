using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityFastAPI.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }

        public Driver(Водители dr)
        {
            this.Id = dr.idВодит;
            this.FIO = dr.фиоВодит;
            this.Tel = dr.телВодит;
            this.Password = dr.пароль;
            this.Model = dr.маркаАвто;
            this.Number = dr.номерАвто;
        }
    }
}