﻿using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient("Jessica");
            myLetterVariable.SetSender("John");
            return View(myLetterVariable);
        }

        [Route("/journal")]
        public ActionResult Journal()
        {
            return View();
        }

        [Route("/form")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Letter", myLetterVariable);
        }
    }
}