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

        public IActionResult GettingStarted(int id)
        {
            var viewModel = new GettingStartedViewModel();
            viewModel.MeetID = id;

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

        public IActionResult ScoreMeet(int id)
        {
            var viewModel = new ScoreMeetViewModel();
            viewModel.MeetID = id;

            var meetAthletes = _powerliftDBContext.Athletes.Where(athlete => athlete.MeetID == id);

            if(meetAthletes.Count() == 0)
            {
                viewModel.AthletesExist = false;
            }
            else
            {
                viewModel.AthletesExist = true; //we need this to remain constant throughout the scoring...
                //add a static property or make it a service value??
            }

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

           //BELOW LOGIC IF UPLOAD MEET DATA FIRST



            //BELOW LOGIC IF UPLOAD ATHLETES BEFORE MEET DATA

            //var meetAthletes = _powerliftDBContext.Athletes.Where(athlete => athlete.MeetID == 0);
            //var currentMeet = _powerliftDBContext.Meets.Where(meet => meet.MeetName == viewModel.MeetName).FirstOrDefault();

            //foreach (var athlete in meetAthletes)
            //{
            //    athlete.MeetID = currentMeet.MeetID;
            //    _powerliftDBContext.SaveChanges();
            //}

            return View("ScoreMeet");
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
