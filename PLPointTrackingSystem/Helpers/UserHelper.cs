using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PLPointTrackingSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Helpers
{
    public class UserHelper
    {
        private readonly PowerliftDBContext _powerliftDBContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;

        public UserHelper(PowerliftDBContext powerliftDBContext,
            UserManager<IdentityUser> userManager,
            IHttpContextAccessor contextAccessor)
        {
            _powerliftDBContext = powerliftDBContext;
            _userManager = userManager;
            _contextAccessor = contextAccessor;
        }
        public async Task<List<Meet>> ListMeets()
        {
            var scorer = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
            var scorerList = _powerliftDBContext.Meets.Where(user => user.Id == scorer.Id).ToList();
            var meets = scorerList.Select(meet => new Meet()
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

            return meets;
        }
    }
}
