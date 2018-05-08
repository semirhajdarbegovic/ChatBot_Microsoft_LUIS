using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChatBot;
using ChatBotWeb.Models;

namespace ChatBotWeb.Controllers
{
    public class HomeController : Controller
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();
        // GET: Home
        public ActionResult Index()
        {
            List<Intent_Statistics> podaci = new List<Intent_Statistics>();
            List<string> nameData = new List<string>();
            List<int?> numberData = new List<int?>();
            foreach (var p in db.sp_Get_Intent_Statistics().ToList())
            {
                Intent_Statistics podatak = new Intent_Statistics();
                podatak.Name = p.Name;
                podatak.Number = p.Number;
                podaci.Add(podatak);
                nameData.Add(p.Name);
                numberData.Add(p.Number);
            }
            numberData.Add(50);
            ViewData["Podaci"] = podaci;

            ViewData["NameData"] = nameData;
            ViewData["NumberData"] = numberData;
            return View();
        }

        public ActionResult TrainData()
        {
            List<ListaOdgovora> listaOdgovora = new List<ListaOdgovora>();
            ListaOdgovora odgovor = new ListaOdgovora();
            foreach (var odg in db.TrainedQuestion)
            {
                odgovor.Question = odg.TrainedQuestion1;
                odgovor.Answer = new List<string>();
                foreach (TrainedAnswer answer in db.TrainedAnswer)
                {
                    if(answer.TrainedQuestionId == odg.TrainedQuestionId)
                        odgovor.Answer.Add(answer.TrainedAnswer1.ToString());
                }
                listaOdgovora.Add(odgovor);
                odgovor = new ListaOdgovora();
            }
            ViewData["Podaci"] = listaOdgovora;
            return View();
        }

        public ActionResult InsertData(string pitanje, string[] odgovor)
        {
            bool imaPitanje = false;
            TrainedQuestion trainedQuestion = new TrainedQuestion();
            TrainedAnswer trainedAnswer = new TrainedAnswer();

            foreach (TrainedQuestion pitanjeTr in db.TrainedQuestion)
            {
                if (pitanjeTr.TrainedQuestion1 == pitanje)
                {
                    foreach (TrainedAnswer odgovorTr in db.TrainedAnswer)
                    {
                        for (int i = 0; i < odgovor.Length; i++)
                        {
                            if (odgovorTr.TrainedAnswer1 == odgovor[i])
                                odgovor[i] = String.Empty;
                        }
                    }
                    imaPitanje = true;
                    trainedQuestion = pitanjeTr;
                }
            }

            if (odgovor.Length > 0)
            {
                if (!imaPitanje)
                {
                    trainedQuestion.TrainedQuestion1 = pitanje;
                    trainedQuestion.TrainedQuestionId = db.TrainedQuestion.Add(trainedQuestion).TrainedQuestionId;

                    db.SaveChanges();
                }
                else
                {
                    trainedQuestion.TrainedQuestionId = trainedQuestion.TrainedQuestionId;
                }
                for (int i = 0; i < odgovor.Length; i++)
                {
                    if (odgovor[i] != "")
                    {
                        trainedAnswer.TrainedAnswer1 = odgovor[i];
                        trainedAnswer.TrainedQuestionId = trainedQuestion.TrainedQuestionId;

                        db.TrainedAnswer.Add(trainedAnswer);
                        db.SaveChanges();
                    }
                }
                
            }

            return RedirectToAction("TrainData");
        }
    }
}