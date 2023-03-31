using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.DTOs
{
    public class LoginDto  //DTO GÖRÜYORSAK BUNLAR CLIENTLARIN GÖRECEĞİ METOTLARDIR DİYEBİLİRİZ
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
