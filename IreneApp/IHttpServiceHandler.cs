using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IreneApp
{
    interface IHttpServiceHandler
    {
        HttpClientHandler GetInsecureHandler();
    }
}
