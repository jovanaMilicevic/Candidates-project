using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<CandidateSkill> CandidateSkills { get; set; }
        
        public Skill()
        {

        }
    }
}
