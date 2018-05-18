using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace org.oas.cidh.eVote.Models
{
    public class VoteProcess
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CloseAutomatically { get; set; }
        public string CaseId { get; set; }
        public string MeasureId { get; set; }
        public List<Country> Countries { get; set; }
        public int ParentId { get; set; }
        public VoteProcess Parent { get; set; }
        public List<int> MemberIds { get; set; }
        public List<int> StaffIds { get; set; }
        public List<string> MainDocIds { get; set; }
        public List<string> SupportDocIds { get; set; }
        public int StatusId { get; set; }
        public Dictionary<int, bool> Votes { get; set; }
        public VotingResult Result { get; set; }
    }

    public enum VotingResult { Aprobado, NoAprobado, Pendiente };
}