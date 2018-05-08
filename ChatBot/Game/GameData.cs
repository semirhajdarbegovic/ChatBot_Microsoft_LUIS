using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatBot.Game
{
    public class GameData
    {
        public static GameModel getQuestion(int num)
        {
            List<GameModel> gameModel = new List<GameModel>();
            gameModel.Add(new GameModel(){questionId = 1, answer = "Really, that's interesting.", question = "Would you rather  1. Continue with your life or  2. Restart it?" });
            gameModel.Add(new GameModel(){ questionId = 2, answer = "I think i can agree with you.", question = "Would you rather  1. Age only from the neck up or  2. Only from the neck down?" });
            gameModel.Add(new GameModel() { questionId = 3, answer = "Eating is better, maybe.", question = "Would you rather  1. Eat everything you see or  2. Lick everything you see?" });
            gameModel.Add(new GameModel() { questionId = 4, answer = "I think I would choose 2.", question = "Would you rather  1. Be rich and alone or  2. Be poor and find true love?" });
            gameModel.Add(new GameModel() { questionId = 5, answer = "I would choose 1. I like to speak :P", question = "Would you rather  1. Always have to say everything on your mind or   2. Never speak again?" });
            gameModel.Add(new GameModel() { questionId = 6, answer = "Hmm this is interesting.", question = "Would you rather  1. Be able to see 10 minutes into your own future or  2. 10 minutes into the future of anyone but yourself? " });
            gameModel.Add(new GameModel() { questionId = 7, answer = "I don't like jails :P", question = "Would you rather  1.  Go to jail for 4 years for something you didn’t do or  2. get away with something horrible you did but always live in fear of being caught?" });
            gameModel.Add(new GameModel() { questionId = 8, answer = "I would not answer", question = "Would you rather  1.  Accidentally be responsible for the death of a child or  2. Accidentally be responsible for the deaths of three adults?" });
            gameModel.Add(new GameModel() { questionId = 9, answer = "I would choose 1.", question = "Would you rather  1.  Live your entire life in a virtual reality where all your wishes are granted or  2. In the real world?" });
            gameModel.Add(new GameModel() { questionId = 10, answer = "Maybe second", question = "Would you rather  1.  Be the first person to explore a planet or  2. Be the inventor of a drug that cures a deadly disease?" });
            gameModel.Add(new GameModel() { questionId = 11, answer = "I would choose 1. I like to speak :P", question = "Would you rather  1.  Go back to age 5 with everything you know now  2.  Or know now everything your future self will learn?" });
            gameModel.Add(new GameModel() { questionId = 12, answer = "I would choose 1. I like to speak :P", question = "Would you rather  1.  Know the history of every object you touched or   2.  Be able to talk to animals?" });



            return gameModel[num];
        }
    }
}