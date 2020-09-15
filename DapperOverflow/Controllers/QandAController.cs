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

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string username, string title, string detail)
        {
            Question newquestion = Question.Create(username, title, detail);
            //newquestion.Add();
            return RedirectToAction("Index");
        }

        /*public IActionResult Search() 
        {
            List<Question> list = Question.ReadAll();
            return View(list);
        }*/
        public IActionResult Detail(long _id)
        {
            Question question = Question.Read(_id);
            return View(question);
        }
        public IActionResult Edit(long _id)
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
        public IActionResult Answer(long _id)
        {
            return View();
        }
        public IActionResult Close(long _id, int status)
        {
            Question.Update(_id, status);
            return RedirectToAction("Index");
        }
        public IActionResult Search(string search)
        {
            List<Question> questionlist = Question.Search(search);
            int results = questionlist.Count();
            ViewBag.Searchresult = $"Search Results for \"{search}\" - {results}";
            return View("Index", questionlist);
        }
    }
}
