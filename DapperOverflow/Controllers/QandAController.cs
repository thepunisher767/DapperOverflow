using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DapperOverflow.Models;

namespace DapperOverflow.Controllers
{
    public class QandAController : Controller
    {

        //GENERAL ####################################################################################
        [HttpGet]
        public IActionResult Index() //Displays ALL question
        {
            List<Question> list = Question.ReadAll();            
            return View(list);
        }
        [HttpPost]
        public IActionResult Index(List<Question> list)
        {
            return View(list);
        }

        public IActionResult Detail(long _id)
        {
            Question question = Question.Read(_id);
            ViewBag.Answerlist = Answer.GetAnswers(_id);
            return View(question);
        }

        //QUESTIONS #####################################################################################################
        public IActionResult Add() //General "blank" ADD view
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string username, string title, string detail) //Create new question
        {
            Question newquestion = Question.Create(username, title, detail);
            return RedirectToAction("Index");
        }

        public IActionResult Close(long _id, int status) //Closes Question
        {
            Question.Update(_id, status);
            return RedirectToAction("Index");
        }

        public IActionResult Search(string search) //Searches based on input
        {
            List<Question> questionlist = Question.Search(search);
            int results = questionlist.Count();
            ViewBag.Searchresult = $"Search Results for \"{search}\" - {results}";
            return View("Index", questionlist);
        }

        public IActionResult Edit(long _id) //Shows pre-populated add view
        {
            Question question = Question.Read(_id);
            return View(question);
        }

        public IActionResult Save(long _id, string username, string title, string detail)
        {
            Question question = Question.Update(_id, username, title, detail);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(long _id)
        {
            Question.Delete(_id);
            return RedirectToAction("Index");
        }

        //ANSWERS ##########################################################################################
        public IActionResult GetAnswer(long _id) //Gets specific answer based on ID
        {
            Answer newanswer = Answer.Read(_id);
            return View("AddAnswer", newanswer);
        }

        public IActionResult AddAnswer(long _id) //With QuestionID
        {
            ViewBag.QuestionID = _id;
            return View();
        }

        [HttpPost]
        public IActionResult EditAnswer(Answer answer) //FIX MEEEEEE
        {
            return View("AddAnswer", answer);
        }

        [HttpPost]
        public IActionResult AnsSave(long _id, long _questionid, string username, string detail)
        {
            Answer newanswer;
            if (_id == 0)
            {
                newanswer = Answer.Create(username, _questionid, detail);
            }
            else
            {
                newanswer = Answer.Update(_id, username, detail);
            }
            return RedirectToAction("Index");
        }

        
    }
}
