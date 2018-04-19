using org.oas.cidh.eVote.Models;
using org.oas.cidh.eVote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace org.oas.cidh.eVote.Controllers
{
    public class ProcessesController : Controller
    {
        List<VoteProcess> processes = new List<VoteProcess> {
            new VoteProcess {
                Id = 1,
                Category = new Category { Name = "Admissibility report" },
                Subject = new Subject{ Name="Children" },
                Countries = new  List<Country> { new Country {Name="Argentina", ImgURL= "~/Content/img/flags/AR.gif" } },
                CaseId = "P-111-111",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date
            },
            new VoteProcess {
                Id = 1,
                Category = new Category { Name = "Press release" },
                Subject = new Subject{ Name="Women" },
                Countries = new  List<Country> { new Country {Name="Peru", ImgURL="~/Content/img/flags/PE.gif" } },
                CaseId = "P-222-222",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date
            },
            new VoteProcess {
                Id = 1,
                Category = new Category { Name = "Press report" },
                Subject = new Subject{ Name="Men" },
                Countries = new  List<Country> { new Country {Name="Venezuela", ImgURL= "~/Content/img/flags/VE.gif" } },
                CaseId = "P-333-333",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date
            }
        }; 


        // GET: Processes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pending()
        {
            VotingProcessesViewModel viewModel = new VotingProcessesViewModel
            {
                VotingProcesses = processes
            };

            return View(viewModel);
        }

        public ActionResult Closed()
        {
            return View();
        }

        public ActionResult InProgress()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Vote()
        {
            return View();
        }
    }
}