using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatBot.Game
{
    [Serializable]
    public class GameModel
    {
        public int questionId { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}