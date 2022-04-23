using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CityFastAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public bool Status { get; set; }

        public Order(Заказы or)
        {
            this.Id = or.idЗаказа;
            this.Cost = or.стоимость;
            this.Status = or.статус;
        }
    }
}