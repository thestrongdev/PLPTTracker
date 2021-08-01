using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PLPointTrackingSystem.DALModels;
using PLPointTrackingSystem.Helpers;
using PLPointTrackingSystem.Models.Home;
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
        private readonly UserHelper _helper;

        public PLMController(PowerliftDBContext powerliftDBContext,
            UserManager<IdentityUser> userManager, UserHelper helper)
        {
            _powerliftDBContext = powerliftDBContext;
            _userManager = userManager;
            _helper = helper;
        }

        public IActionResult Index()
        {
            return View();
        }
  
        [Authorize]
        public IActionResult GettingStarted(int id)
        {
            var viewModel = new GettingStartedViewModel();
            viewModel.MeetID = id;

            return View();
        }

        public IActionResult ScorerInfoForm()
        {
            return View();
        }

        public async Task<IActionResult> StoreScorerInfo(ScorerInfoFormViewModel viewModel)
        {
            var scorer = await _userManager.GetUserAsync(User);

            var member = new MemberDAL();
            member.Role = viewModel.Role;
            member.Id = scorer.Id;
            _powerliftDBContext.MemberRoles.Add(member);
            _powerliftDBContext.SaveChanges();

            var home = new IndexViewModel();

            return View("~/Views/Home/Index.cshtml", home);
        }

        public IActionResult MeetInfoForm()
        {
            return View();
        }

        public async Task<IActionResult> StoreMeetInfo(MeetInfoFormViewModel viewModel)
        {
            var scorer = await _userManager.GetUserAsync(User);

            var meet = new MeetDAL();
            meet.Id = scorer.Id;
            meet.MeetName = viewModel.MeetName;
            meet.MeetType = viewModel.MeetType;
            meet.MeetState = viewModel.MeetState;
            meet.MeetVenue = viewModel.MeetVenue;
            meet.MeetCity = viewModel.MeetCity;
            meet.MeetFed = viewModel.MeetFed;
            meet.MeetDate = viewModel.MeetDate;
            meet.MeetZip = viewModel.MeetZip;
            

            _powerliftDBContext.Add(meet);
            _powerliftDBContext.SaveChanges();

            var meetListView = new MeetListViewModel();
            
            var scorerRole = _powerliftDBContext.MemberRoles.Where(user => user.Id == scorer.Id).FirstOrDefault();

            if(scorerRole != null)
            {
                meetListView.MemberRoleUpdated = true;
            }

            meetListView.MembersMeets = new List<Meet>();
            meetListView.MembersMeets = await _helper.ListMeets();

            return View("MeetList", meetListView);
        }


        public async Task<IActionResult> MeetList()
        {
            var scorer = await _userManager.GetUserAsync(User);

            var viewModel = new MeetListViewModel();
            //grab meets from database
            var scorerList = _powerliftDBContext.Meets.Where(user => user.Id == scorer.Id).ToList();
            viewModel.MembersMeets = new List<Meet>();
            viewModel.MembersMeets = scorerList.Select(meet => new Meet()
            {
                MeetCity = meet.MeetCity,
                MeetDate = meet.MeetDate,
                MeetFed = meet.MeetFed,
                MeetName = meet.MeetName,
                MeetState = meet.MeetState,
                MeetType =meet.MeetType,
                MeetVenue = meet.MeetVenue,
                MeetID = meet.MeetID,
                AthleteDataUploaded = meet.AthleteDataUploaded

            }).ToList();

            var memberRole = _powerliftDBContext.MemberRoles.Where(user => user.Id == scorer.Id).FirstOrDefault();

            if(memberRole != null)
            {
                viewModel.MemberRoleUpdated = true;
            }

            return View(viewModel);
        }

        public async Task<IActionResult> DeleteMeet(int id)
        {
            var scorer = await _userManager.GetUserAsync(User);
            //first check if athletes exist
            var athletesExist = _powerliftDBContext.Athletes.Where(athlete => athlete.MeetID == id);

            //first remove athletes from athlete table
            if (athletesExist.Count() == 0)
            {
                _powerliftDBContext.Athletes.RemoveRange(athletesExist);
                _powerliftDBContext.SaveChanges();
            }

            var meetToRemove = _powerliftDBContext.Meets.Where(meet => meet.MeetID == id).FirstOrDefault();


            //then remove meet from meet table
            _powerliftDBContext.Meets.Remove(meetToRemove);
            _powerliftDBContext.SaveChanges();

            var viewModel = new MeetListViewModel();

            //need to route back to meet list and add same logic here!!!
            var scorerList = _powerliftDBContext.Meets.Where(user => user.Id == scorer.Id).ToList();
            viewModel.MembersMeets = new List<Meet>();
            viewModel.MembersMeets = scorerList.Select(meet => new Meet()
            {
                MeetCity = meet.MeetCity,
                MeetDate = meet.MeetDate,
                MeetFed = meet.MeetFed,
                MeetName = meet.MeetName,
                MeetState = meet.MeetState,
                MeetType = meet.MeetType,
                MeetVenue = meet.MeetVenue,
                MeetID = meet.MeetID,
                AthleteDataUploaded = meet.AthleteDataUploaded

            }).ToList();

            var memberRole = _powerliftDBContext.MemberRoles.Where(user => user.Id == scorer.Id).FirstOrDefault();

            if (memberRole != null)
            {
                viewModel.MemberRoleUpdated = true;
            }

            return View("MeetList", viewModel);
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
