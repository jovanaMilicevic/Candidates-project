using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class Lists
    {
        public Candidate Candidate { get; set; }
        public List<Skill> HasSkills { get; set; }
        public List<Skill> DoesntHaveSkills { get; set; }
    }
}
