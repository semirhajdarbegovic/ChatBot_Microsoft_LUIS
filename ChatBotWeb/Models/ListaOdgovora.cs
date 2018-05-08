using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatBotWeb.Models
{
    public class ListaOdgovora
    {
        public string Question { get; set; }
        public List<string> Answer { get; set; }
    }
}