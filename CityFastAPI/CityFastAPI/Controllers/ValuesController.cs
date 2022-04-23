using CityFastAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityFastAPI.Controllers
{
    public class ValuesController : ApiController
    {
        Random r = new Random();
        string s = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
        public static CityFastEntities1 db = new CityFastEntities1();

        // GET api/values

        [Route("orders")]
        [HttpGet]
        public Order[] Get()
        {
            return db.Заказы.ToArray().Select(c => new Order(c)).ToArray();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        
        [Route("register")]
        [HttpPost]
        public string RegisterUser(string user, string fio, string tel, string password, string modelAuto = "null", string nomerAuto = "null")
        {
            switch (user)
            {
                case "Клиент":
                    var client = db.Клиенты.FirstOrDefault(c => c.телКл == tel);
                    if (client == null)
                    {
                        // создаем нового пользователя
                        client = new Клиенты()
                        {
                            фиоКл = fio,
                            телКл = tel,
                            парольКл = password,
                            токенКл = ""
                        };
                        // генерируем токен
                        for (int i = 0; i < 20; i++)
                        {
                            client.токенКл += s[r.Next(0, s.Length)];
                        }

                        // добавляем в БД
                        db.Клиенты.Add(client);
                        db.SaveChanges();

                        // выдаем токен
                        return client.токенКл;
                    }
                    else
                    {
                        // если такой пользователь уже есть, выдаем сообщение об ошибке
                        return "Такой пользователь уже зарегистрирован";
                    }
                case "Водитель":
                    var driver = db.Водители.FirstOrDefault(c => c.телВодит == tel);
                    if (driver == null)
                    {
                        // создаем нового пользователя
                        driver = new Водители()
                        {
                            фиоВодит = fio,
                            телВодит = tel,
                            парольВодит = password,
                            маркаАвто = modelAuto,
                            номерАвто = nomerAuto,
                            токенВодит = ""
                        };
                        // генерируем токен
                        for (int i = 0; i < 20; i++)
                        {
                            driver.токенВодит += s[r.Next(0, s.Length)];
                        }

                        // добавляем в БД
                        db.Водители.Add(driver);
                        db.SaveChanges();

                        // выдаем токен
                        return driver.токенВодит;
                    }
                    else
                    {
                        // если такой пользователь уже есть, выдаем сообщение об ошибке
                        return "Такой пользователь уже зарегистрирован";
                    }
                case "Диспетчер":
                    var dispatcher = db.Диспетчеры.FirstOrDefault(c => c.телДисп == tel);
                    if (dispatcher == null)
                    {
                        // создаем нового пользователя
                        dispatcher = new Диспетчеры()
                        {
                            фиоДисп = fio,
                            телДисп = tel,
                            парольДисп = password,
                            токенДисп = ""
                        };
                        // генерируем токен
                        for (int i = 0; i < 20; i++)
                        {
                            dispatcher.токенДисп += s[r.Next(0, s.Length)];
                        }

                        // добавляем в БД
                        db.Диспетчеры.Add(dispatcher);
                        db.SaveChanges();

                        // выдаем токен
                        return dispatcher.токенДисп;
                    }
                    else
                    {
                        // если такой пользователь уже есть, выдаем сообщение об ошибке
                        return "Такой пользователь уже зарегистрирован";
                    }
                default:
                    return "Ошибка 010101";
            }
        }
        
        [Route("login")]
        [HttpPost]
        public string LoginUser(string user, string tel, string password)
        {
            switch (user)
            {
                case "Клиент":
                    var client = db.Клиенты.FirstOrDefault(c => c.телКл == tel && c.парольКл == password);
                    if (client != null)
                    {
                        // генерируем новый токен клиенту
                        for (int i = 0; i < 20; i++)
                        {
                            client.токенКл += s[r.Next(0, s.Length)];
                        }

                        // выдаем токен пользователю
                        return client.токенКл;
                    }
                    // если пользователь не найден, выдаем ошибку
                    return "Неверный логин или пароль";
                case "Водитель":
                    var driver = db.Водители.FirstOrDefault(c => c.телВодит == tel && c.парольВодит == password);
                    if (driver != null)
                    {
                        // генерируем новый токен клиенту
                        for (int i = 0; i < 20; i++)
                        {
                            driver.токенВодит += s[r.Next(0, s.Length)];
                        }

                        // выдаем токен пользователю
                        return driver.токенВодит;
                    }
                    // если пользователь не найден, выдаем ошибку
                    return "Неверный логин или пароль";
                case "Диспетчер":
                    var dispatcher = db.Диспетчеры.FirstOrDefault(c => c.телДисп == tel && c.парольДисп == password);
                    if (dispatcher != null)
                    {
                        // генерируем новый токен клиенту
                        for (int i = 0; i < 20; i++)
                        {
                            dispatcher.токенДисп += s[r.Next(0, s.Length)];
                        }

                        // выдаем токен пользователю
                        return dispatcher.токенДисп;
                    }
                    // если пользователь не найден, выдаем ошибку
                    return "Неверный логин или пароль";
                default:
                    return "Ошибка 101010";
            }

            
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
