﻿using org.oas.cidh.eVote.Models;
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
        #region SeedData
        List<VoteProcess> _processes = new List<VoteProcess> {
            new VoteProcess {
                Id = 1,
                Category = new Category { Name = "Admissibility report" },
                Subject = new Subject{ Name="Children" },
                Countries = new  List<Country> { new Country {Name="Argentina", ImgURL= "/Content/img/flags/AR.gif" } },
                CaseId = "P-111-111",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=1
            },
            new VoteProcess {
                Id = 2,
                Category = new Category { Name = "Press release" },
                Subject = new Subject{ Name="Women" },
                Countries = new  List<Country> { new Country {Name="Peru", ImgURL="/Content/img/flags/PE.gif" } },
                CaseId = "P-222-222",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=1
            },
            new VoteProcess {
                Id = 3,
                Category = new Category { Name = "Press report" },
                Subject = new Subject{ Name="Men" },
                Countries = new  List<Country> { new Country {Name="Venezuela", ImgURL= "/Content/img/flags/VE.gif" } },
                CaseId = "P-333-333",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=1
            },
            new VoteProcess {
                Id = 4,
                Category = new Category { Name = "Admissibility report" },
                Subject = new Subject{ Name="Children" },
                Countries = new  List<Country> { new Country {Name="Chile", ImgURL= "/Content/img/flags/CH.gif" } },
                CaseId = "P-444-444",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2
            },
            new VoteProcess {
                Id = 5,
                Category = new Category { Name = "Press release" },
                Subject = new Subject{ Name="Women" },
                Countries = new  List<Country> { new Country {Name="Peru", ImgURL="/Content/img/flags/PE.gif" } },
                CaseId = "P-555-555",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2
            },
            new VoteProcess {
                Id = 6,
                Category = new Category { Name = "Press report" },
                Subject = new Subject{ Name="Men" },
                Countries = new  List<Country> { new Country {Name="Venezuela", ImgURL= "/Content/img/flags/VE.gif" } },
                CaseId = "P-666-666",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2
            },
            new VoteProcess {
                Id = 7,
                Category = new Category { Name = "Admissibility report" },
                Subject = new Subject{ Name="Children" },
                Countries = new  List<Country> { new Country {Name="Argentina", ImgURL= "/Content/img/flags/AR.gif" } },
                CaseId = "P-777-777",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2
            },
            new VoteProcess {
                Id = 8,
                Category = new Category { Name = "Press release" },
                Subject = new Subject{ Name="Women" },
                Countries = new  List<Country> { new Country {Name="Peru", ImgURL="/Content/img/flags/PE.gif" } },
                CaseId = "P-888-888",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2
            },
            new VoteProcess {
                Id = 9,
                Category = new Category { Name = "Press report" },
                Subject = new Subject{ Name="Men" },
                Countries = new  List<Country> { new Country {Name="Bolivia", ImgURL= "/Content/img/flags/BO.gif" } },
                CaseId = "P-999-999",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=3
            },
            new VoteProcess {
                Id = 10,
                Category = new Category { Name = "Press report" },
                Subject = new Subject{ Name="Men" },
                Countries = new  List<Country> { new Country {Name="Bolivia", ImgURL= "/Content/img/flags/BO.gif" } },
                CaseId = "P-101-010",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=3
            }
        };
        #endregion

        // GET: Processes
        public ActionResult Index()
        {
            VotingProcessesViewModel viewModel = new VotingProcessesViewModel
            {
                VotingProcesses = _processes
            };

            return View(viewModel);
        }

        public ActionResult Pending()
        {
            VotingProcessesViewModel viewModel = new VotingProcessesViewModel
            {
                VotingProcesses = _processes
            };

            return View(viewModel);
        }

        public ActionResult InProgress()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var process = _processes.SingleOrDefault<VoteProcess>(c => c.Id == id);

            return View(process);
        }

        public ActionResult Closed(int id)
        {
            var process = _processes.SingleOrDefault<VoteProcess>(c => c.Id == id);

            return View(process);
        }

        public ActionResult Vote()
        {
            return View();
        }

        public ActionResult Docs()
        {
            return View();
        }
    }
}