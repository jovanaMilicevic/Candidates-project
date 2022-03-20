using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Candidates.Data;
using Candidates.Models;

namespace Candidates.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CandidatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Candidate.ToListAsync());
        }

        public async Task<IActionResult> AddSkill(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lists lists = new Lists();
            lists.DoesntHaveSkills = new List<Skill>();
            lists.HasSkills = new List<Skill>();
            List<CandidateSkill> candidateSkill = await _context.CandidateSkills.Where(c=>c.Idc == id).ToListAsync();
            List<Skill> skills = await _context.Skill.ToListAsync();
            foreach (var i in skills)
            {
                bool prvr = false;
                foreach (var y in candidateSkill)
                {
                    if(y.Ids == i.Id)
                    {
                        prvr = true;
                        break;
                    }
                }
                if (prvr)
                    lists.HasSkills.Add(i);
                else
                    lists.DoesntHaveSkills.Add(i); 
            }

            lists.Candidate = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Id == id);
            

            return View(lists);
        }



        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var candidate = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }

            Lists lists = new Lists();
            lists.Candidate = candidate;
            lists.HasSkills = new List<Skill>();

            List<CandidateSkill> candidateSkill = await _context.CandidateSkills.Where(c => c.Idc == id).ToListAsync();
            List<Skill> skills = await _context.Skill.ToListAsync();
            foreach (var i in skills)
            {
                foreach (var y in candidateSkill)
                {
                    if (y.Ids == i.Id)
                    {
                        lists.HasSkills.Add(i);
                        break;
                    }
                }
            }

            return View(lists);
        }

        // GET: Candidates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DateOfBirth,Number,Email")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            return View(candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DateOfBirth,Number,Email")] Candidate candidate)
        {
            if (id != candidate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExists(candidate.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidate = await _context.Candidate.FindAsync(id);
            _context.Candidate.Remove(candidate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool CandidateExists(int id)
        {
            return _context.Candidate.Any(e => e.Id == id);
        }

        // POST: Candidates/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSkills([FromForm] int idc, [FromForm] int ids)
        {
            CandidateSkill candidateSkill = new CandidateSkill();
            candidateSkill.Idc = idc;
            candidateSkill.Ids = ids;

            _context.CandidateSkills.Add(candidateSkill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(AddSkill)+ "/" +idc);
        }

        // POST: Candidates/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveSkill([FromForm] int idc, [FromForm] int ids)
        {
            CandidateSkill candidateSkill = new CandidateSkill();
            candidateSkill.Idc = idc;
            candidateSkill.Ids = ids;

            _context.CandidateSkills.Remove(candidateSkill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(AddSkill) + "/" + idc);
        }

        //GET: Candidates/Search
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search([FromForm] String searchPhrase)
        {
            if(string.IsNullOrEmpty(searchPhrase))
            {
                return RedirectToAction(nameof(Index), await _context.Candidate.ToListAsync());
            }
            List<Candidate> list = new List<Candidate>();
            foreach (var i in await _context.Candidate.ToListAsync())
            {
                if(i.Name.ToLower().Contains(searchPhrase.ToLower()))
                {
                    list.Add(i);
                    continue;
                }
                foreach (var y in await _context.CandidateSkills.Where(sk => sk.Idc == i.Id).ToListAsync())
                {
                    Skill skill = await _context.Skill.FirstAsync(s => s.Id == y.Ids);
                    if (skill!=null && skill.Name.ToLower().Contains(searchPhrase.ToLower()))
                    {
                        list.Add(i);
                        break;
                    }
                }
            }
            return View(nameof(Index), list);
        }
    }
}
