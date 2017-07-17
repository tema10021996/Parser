using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Parser.DAL.Entities;

namespace Parser.Controllers
{
    public class ParserController : Controller
    {
        ParserWorker<string[]> parser;
        
        // GET: Parser
        public ActionResult Index()
        {
            parser = new ParserWorker<string[]>(
                new SimpleParser()
                );

            parser.Settings = new Settings(1, 2);
            parser.Start();


            return View(parser);
        }
    }
}