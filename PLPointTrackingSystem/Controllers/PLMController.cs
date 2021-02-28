using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult UploadMeetData()
        {
            return View();
        }

        public IActionResult UploadAthleteData()
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
