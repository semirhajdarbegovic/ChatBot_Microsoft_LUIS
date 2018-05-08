using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace ChatBot.Controllers
{
    [Serializable]
    public class QureyController
    {

        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        // POST: api/Session
        public void PostSession(Session session)
        {
            db.Session.Add(session);
            db.SaveChanges();

        }

        // GET: api/Question
        public string GetAnswer(string userInput, string intentName, string intentScore, string entityScore)
        {
            int sessionId = int.Parse(db.Session.OrderByDescending(x=>x.SessionId).Select(x=>x.SessionId).First().ToString());

            int intentId = db.Intent.Where(x => x.Name == intentName).Select(x => x.IntentId).FirstOrDefault();

           int scoreId = Convert.ToInt32(db.sp_ScoreInsert(Convert.ToDecimal(intentScore), Convert.ToDecimal(intentScore)).FirstOrDefault());

            int questionId = Convert.ToInt32(db.sp_QuestionInsert(userInput, intentId, scoreId, DateTime.Now, sessionId).FirstOrDefault());

            var answer = db.sp_GetAnswer(questionId, sessionId, intentId).FirstOrDefault();

            string rtr_str = "";

            if (answer != null)
                rtr_str = answer;

            return rtr_str;

        }

        // GET: api/Question
        public string GetTrainedAnswer(string questionInput)
        {
            var answer = db.sp_GetTrainedAnswer(questionInput).FirstOrDefault();

            string rtr_str = "";

            if (answer != null)
                rtr_str = answer.TrainedAnswer;
            else
                rtr_str = "Hmmm ...";

            return rtr_str;
        }

        // POST: api/TrainedAnswer

        public void PostTrainedAnswer(string question, string answer)
        {
            TrainedQuestion trainedQuestion = new TrainedQuestion();
            TrainedAnswer trainedAnswer = new TrainedAnswer();

            trainedQuestion.TrainedQuestion1 = question;

            int questionId =  db.TrainedQuestion.Add(trainedQuestion).TrainedQuestionId;
            trainedAnswer.TrainedAnswer1 = answer;
            trainedAnswer.TrainedQuestionId = questionId;

            db.TrainedAnswer.Add(trainedAnswer);

            db.SaveChanges();
        }

        // POST: api/Answer
        public void PostAnswer(string userInput, string botAnswer, string intentName, string intentScore, string entityScore)
        {
            int sessionId = int.Parse(db.Session.OrderByDescending(x => x.SessionId).Select(x => x.SessionId).First().ToString());

            int intentId = db.Intent.Where(x => x.Name == intentName).Select(x => x.IntentId).FirstOrDefault();

            int scoreId = Convert.ToInt32(db.sp_ScoreInsert(Convert.ToDecimal(intentScore), Convert.ToDecimal(intentScore)).FirstOrDefault());

            int questionId = Convert.ToInt32(db.sp_QuestionInsert(userInput, intentId, scoreId, DateTime.Now, sessionId).FirstOrDefault());

            BotReply br = new BotReply();
            br.QuestionId = questionId;
            br.SessionId = sessionId;
            br.AnswerId = Convert.ToInt32(db.sp_AnswerInsert(intentId, botAnswer, false).FirstOrDefault());
            db.BotReply.Add(br);
            db.SaveChanges();

        }

        // POST: api/Answer
        public void PostQuestionOne(string userInput, string intentName, string intentScore, string entityScore)
        {
            int intentId = db.Intent.Where(x => x.Name == intentName).Select(x => x.IntentId).FirstOrDefault();

            int scoreId = Convert.ToInt32(db.sp_ScoreInsert(Convert.ToDecimal(intentScore), Convert.ToDecimal(intentScore)).FirstOrDefault());

            db.Question.Add(new Question(){DateTime = DateTime.Now, IntentId = intentId, ScoreId = scoreId, UserInput = userInput});
            db.SaveChanges();
        }

        // POST: api/Answer
        public void PostAnswerOne(string botAnswer, string intentName)
        {
            int sessionId = int.Parse(db.Session.OrderByDescending(x => x.SessionId).Select(x => x.SessionId).First().ToString());

            int intentId = db.Intent.Where(x => x.Name == intentName).Select(x => x.IntentId).FirstOrDefault();

            int questionId = int.Parse(db.Question.OrderByDescending(x => x.QuestionId).Select(x => x.QuestionId).First().ToString());

            BotReply br = new BotReply();
            br.QuestionId = questionId;
            br.SessionId = sessionId;
            br.AnswerId = Convert.ToInt32(db.sp_AnswerInsert(intentId, botAnswer, false).FirstOrDefault());
            db.BotReply.Add(br);
            db.SaveChanges();

        }
    }
}