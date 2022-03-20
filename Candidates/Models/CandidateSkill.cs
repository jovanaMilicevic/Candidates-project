using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class CandidateSkill
    {
        public int Ids { get; set; }
        public Skill Skill { get; set; }
        public int Idc { get; set; }
        public Candidate Candidate { get; set; }
    }
}
