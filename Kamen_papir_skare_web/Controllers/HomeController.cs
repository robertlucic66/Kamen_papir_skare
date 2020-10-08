using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kamen_papir_skare_web.Models;

namespace Kamen_papir_skare_web.Controllers
{
    public class HomeController : Controller
    {
        public string inputIgrac, inputCPU;
        int randomInt;
        Igrac igrac = new Igrac();
        bool playAgain = true;

        [HttpGet]
        public ViewResult Index()
        {
            Igrac igrac = new Igrac();
            return View(igrac);
        }

        [HttpPost]
        public ViewResult Index(Igrac igrac)
        {
            while (playAgain == true)
            {
                inputIgrac = igrac.Odabir;
                Random rnd = new Random();
                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "KAMEN";
                        if (inputIgrac == "KAMEN")
                        {
                            ViewBag.Pobjednik = "NERIJEŠENO";
                        }
                        else if (inputIgrac == "PAPIR")
                        {
                            ViewBag.Pobjednik = "Pobjednik je: IGRAČ";
                        }
                        else if (inputIgrac == "ŠKARE" || inputIgrac == "SKARE")
                        {
                            ViewBag.Pobjednik = "Pobjednik je: CPU";
                        }
                        break;

                    case 2:
                        inputCPU = "PAPIR";
                        if (inputIgrac == "KAMEN")
                        {
                            ViewBag.Pobjednik = "Pobjednik je: CPU";
                        }
                        else if (inputIgrac == "PAPIR")
                        {
                            ViewBag.Pobjednik = "NERIJEŠENO";
                        }
                        else if (inputIgrac == "ŠKARE" || inputIgrac == "SKARE")
                        {
                            ViewBag.Pobjednik = "Pobjednik je: IGRAČ";
                        }
                        break;

                    case 3:
                        inputCPU = "SKARE";
                        if (inputIgrac == "KAMEN")
                        {
                            ViewBag.Pobjednik = "Pobjednik je: IGRAČ";
                        }
                        else if (inputIgrac == "PAPIR")
                        {
                            ViewBag.Pobjednik = "Pobjednik je: CPU";
                        }
                        else if (inputIgrac == "ŠKARE" || inputIgrac == "SKARE")
                        {
                            ViewBag.Pobjednik = "NERIJEŠENO";
                        }
                        break;

                    default:
                        break;
                }

                if (inputCPU == "KAMEN")
                {
                    ViewBag.InputCPU = "kamen";
                }
                else if (inputCPU == "PAPIR")
                {
                    ViewBag.InputCPU = "papir";
                }
                else if (inputCPU == "SKARE")
                {
                    ViewBag.InputCPU = "škare";
                }
                return View(igrac);
            }
            return View();
        }
    }
}