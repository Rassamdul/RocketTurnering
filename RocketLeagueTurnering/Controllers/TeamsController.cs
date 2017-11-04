using RocketLeagueTurnering.Models;
using RocketLeagueTurnering.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RocketLeagueTurnering.Controllers
{
    public class TeamsController : Controller
    {
        private RLTDBContext db = new RLTDBContext();
        // GET: Users
        public ActionResult Index()
        {
            List<Team> teams = db.Teams.ToList();
            return View(teams);
        }

        public ActionResult Details(int id)
        {
            var team = db.Teams.SingleOrDefault(c => c.Id == id);
            return View(team);
        }

        public ActionResult New()
        {
            return View("TeamsForm", new TeamFormViewModel());
        }

        public ActionResult Save(Team team)
        {
            if (team.Id == 0)
            {
                db.Teams.Add(team);
            }
            else
            {
                var TeamInDB = db.Teams.Single(c => c.Id == team.Id);
                TeamInDB.TeamName = team.TeamName;
                TeamInDB.Medlem1 = team.Medlem1;
                TeamInDB.Medlem2 = team.Medlem2;
                TeamInDB.Medlem3 = team.Medlem3;
            }

            db.SaveChanges();
            return RedirectToAction("Index", "Teams");
        }


        public ActionResult Delete(Team team)
        {
            Team t = new Team() { Id = team.Id };
            db.Teams.Attach(t);
            db.Teams.Remove(t);

            db.SaveChanges();
            return RedirectToAction("Index", "Teams");
        }
        public ActionResult Edit(int id)
        {
            var team = db.Teams.SingleOrDefault(c => c.Id == id);

            if (team == null)
            {
                return HttpNotFound();
            }

            var viewModel = new TeamFormViewModel
            {
                Team = team

            };
            return View("TeamsForm", viewModel);
        }
    }
}