using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fansoft.Store.UI.Controllers
{
    public class TesteController:Controller
    {
        public string Server()
        {
            return "Bateu no server";
        }
    }
}
