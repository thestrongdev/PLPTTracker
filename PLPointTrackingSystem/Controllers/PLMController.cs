using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PLPointTrackingSystem.DALModels;
using PLPointTrackingSystem.Models.PLM;
using PLPointTrackingSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Controllers
{
    public class PLMController : Controller
    {
        private readonly PowerliftDBContext _powerliftDBContext;
        private readonly UserManager<IdentityUser> _userManager;

        public PLMController(PowerliftDBContext powerliftDBContext,
            UserManager<IdentityUser> userManager)
        {
            _powerliftDBContext = powerliftDBContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GettingStarted()
        {
            return View();
        }

        public IActionResult MeetInfoForm()
        {
            return View();
        }

        public IActionResult MeetList()
        {
            var viewModel = new MeetListViewModel();


            return View();
        }

        public IActionResult ScoreMeet()
        {
            return View();
        }

        public IActionResult LiftMake()
        {
            return View();
        }

        public IActionResult LiftMiss()
        {
            return View();
        }

        public IActionResult ReRankAthletes()
        {
            return View();
        }

        public IActionResult SearchAthletes()
        {
            return View();
        }

        public IActionResult SortAthletes()
        {
            return View();
        }

        //NEED FILTERING FUNCTIONALITY TOO

        public IActionResult SubmitMeetInfo(MeetInfoFormViewModel viewModel)
        {
            var meet = new MeetDAL();
            meet.MeetType = viewModel.MeetType;
            meet.MeetName = viewModel.MeetName;
            meet.MeetFed = viewModel.MeetFed;
            meet.MeetDate = viewModel.MeetDate;
            meet.MeetCity = viewModel.MeetCity;
            meet.MeetState = viewModel.MeetState;
            meet.MeetVenue = viewModel.MeetVenue;

            _powerliftDBContext.Meets.Add(meet); 
            _powerliftDBContext.SaveChanges();

            //if athlete MeetID null or zero?, then populate with this meet's ID!

            var meetAthletes = _powerliftDBContext.Athletes.Where(athlete => athlete.MeetID == 0);
            var currentMeet = _powerliftDBContext.Meets.Where(meet => meet.MeetName == viewModel.MeetName).FirstOrDefault();

            foreach (var athlete in meetAthletes)
            {
                athlete.MeetID = currentMeet.MeetID;
                _powerliftDBContext.SaveChanges();
            }

            return View("MeetScoring");
        }




        //FEATURES TO ADD
        //--------------------------------------------------------------------------------------
        //upload meet and athlete data --- DO THIS ONE ONE VIEW
        //pull out rankings based on specific categories (age, division, weightclass, gender, etc.
        //log in feature for whoever is scoring
        //allow user to save meet data to their account and also download excel files of meet data
        //as meet goes, user should be able to enter athlete data as lifts are made/missed
        //bring in a powerlifting API to see how anyone ranked against people all over the world
        //for each lifter that's lifting, show colors of weights that should be on the barbell

    }
}
