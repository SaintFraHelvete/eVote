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
                Category = new Category { Name = "Informe de País" },
                Subject = new Subject{ Name="Niños" },
                Countries = new  List<Country> { new Country {Name="Argentina", ImgURL= "/CIDH_eVote/Content/img/flags/AR.gif" } },
                CaseId = "P-111-111",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=1,
                Result=VotingResult.Pendiente            },
            new VoteProcess {
                Id = 2,
                Category = new Category { Name = "Informe Temático" },
                Subject = new Subject{ Name="LGBTI" },
                Countries = new  List<Country> { new Country {Name="Peru", ImgURL="/CIDH_eVote/Content/img/flags/PE.gif" }, new Country {Name="Colombia", ImgURL="/CIDH_eVote/Content/img/flags/CO.gif" }, new Country {Name="Ecuador", ImgURL="/CIDH_eVote/Content/img/flags/EC.gif" } },
                CaseId = "P-222-222",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=1,
                Result=VotingResult.Pendiente
            },
            new VoteProcess {
                Id = 3,
                Category = new Category { Name = "Medida Cautelar" },
                Subject = new Subject{ Name="RELE" },
                Countries = new  List<Country> { new Country {Name="Venezuela", ImgURL= "/CIDH_eVote/Content/img/flags/VE.gif" } },
                CaseId = "P-333-333",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=1,
                Result=VotingResult.Pendiente
            },
            new VoteProcess {
                Id = 4,
                Category = new Category { Name = "Corte" },
                Subject = new Subject{ Name="Niñez" },
                Countries = new  List<Country> { new Country {Name="Chile", ImgURL= "/CIDH_eVote/Content/img/flags/CH.gif" } },
                CaseId = "P-444-444",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2,
                Result=VotingResult.Aprobado
            },
            new VoteProcess {
                Id = 5,
                Category = new Category { Name = "Comunicado de prensa" },
                Subject = new Subject{ Name="Mujeres" },
                Countries = new  List<Country> { new Country {Name="Uruguay", ImgURL="/CIDH_eVote/Content/img/flags/UR.gif" } },
                CaseId = "P-555-555",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2,
                Result=VotingResult.NoAprobado
            },
            new VoteProcess {
                Id = 6,
                Category = new Category { Name = "Reporte de prensa" },
                Subject = new Subject{ Name="LGBTI" },
                Countries = new  List<Country> { new Country {Name="Panamá", ImgURL= "/CIDH_eVote/Content/img/flags/PN.gif" } },
                CaseId = "P-666-666",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2,
                Result=VotingResult.Aprobado
            },
            new VoteProcess {
                Id = 7,
                Category = new Category { Name = "Reporte de admisibilidad" },
                Subject = new Subject{ Name="Niños" },
                Countries = new  List<Country> { new Country {Name="Ecuador", ImgURL= "/CIDH_eVote/Content/img/flags/EC.gif" } },
                CaseId = "P-777-777",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2,
                Result=VotingResult.NoAprobado
            },
            new VoteProcess {
                Id = 8,
                Category = new Category { Name = "Comunicado de prensa" },
                Subject = new Subject{ Name="Mujeres" },
                Countries = new  List<Country> { new Country {Name="Brasil", ImgURL="/CIDH_eVote/Content/img/flags/BR.gif" } },
                CaseId = "P-888-888",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=2,
                Result=VotingResult.Aprobado
            },
            new VoteProcess {
                Id = 9,
                Category = new Category { Name = "Reporte de prensa" },
                Subject = new Subject{ Name="LGBTI" },
                Countries = new  List<Country> { new Country {Name="Bolivia", ImgURL= "/CIDH_eVote/Content/img/flags/BO.gif" } },
                CaseId = "P-999-999",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=3,
                Result=VotingResult.NoAprobado
            },
            new VoteProcess {
                Id = 10,
                Category = new Category { Name = "Reporte de prensa" },
                Subject = new Subject{ Name="Hombres oprimidos" },
                Countries = new  List<Country> { new Country {Name="Mexico", ImgURL= "/CIDH_eVote/Content/img/flags/MX.gif" } },
                CaseId = "P-101-010",
                StartDate=DateTime.Now.Date,
                EndDate=DateTime.Now.Date,
                StatusId=3,
                Result=VotingResult.Aprobado
            }
        };
        #endregion

        // GET: Processes/ 
        // Show pending processes by default
        public ActionResult Index()
        {
            VotingProcessesViewModel viewModel = new VotingProcessesViewModel
            {
                VotingProcesses = _processes.Where(x => x.StatusId == 1).ToList<VoteProcess>()
            };

            return View(viewModel);
        }

        // GET: Processes/InProgress
        public ActionResult InProgress()
        {
            VotingProcessesViewModel viewModel = new VotingProcessesViewModel
            {
                VotingProcesses = _processes.Where(x => x.StatusId == 2).ToList<VoteProcess>()
            };

            return View(viewModel);
        }

        // GET: Processes/Closed
        public ActionResult Closed()
        {
            VotingProcessesViewModel viewModel = new VotingProcessesViewModel
            {
                VotingProcesses = _processes.Where(x => x.StatusId == 3).ToList<VoteProcess>()
            };

            return View(viewModel);
        }

        // GET: Processes/Details/{id}
        public ActionResult Details(int id)
        {
            var process = _processes.SingleOrDefault<VoteProcess>(c => c.Id == id);

            return View(process);
        }
    }
}