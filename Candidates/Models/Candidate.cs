using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Number { get; set; }
        public String Email { get; set; }
        public ICollection<CandidateSkill> CandidateSkills { get; set; }


        public Candidate()
        {

        }
    }
}
