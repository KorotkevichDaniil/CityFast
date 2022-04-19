using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityFastAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public bool fastOrder { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }

        public Order(Заказы ord)
        {
            this.Id = ord.idДисп;
            this.FIO = ord.фиоДисп;
            this.Tel = ord.телДисп;
            this.Password = ord.пароль;
        }

    }
}