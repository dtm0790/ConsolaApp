using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumirWebService.Services
{
     interface IHelloWS
    {
        string helloRequest { get; set; }
        string helloResponse { get; set; } 
    }
}
