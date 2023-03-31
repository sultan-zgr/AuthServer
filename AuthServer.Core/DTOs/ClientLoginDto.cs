using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.DTOs
{
    public class ClientLoginDto
    {
        public string ClientId { get; set; } //Name
        public string ClientSecret { get; set; } //Password
    }
}
