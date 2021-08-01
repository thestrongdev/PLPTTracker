using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PLPointTrackingSystem.DALModels;
using PLPointTrackingSystem.Models.PLM;
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

        public async Task StoreMeetInfo(MeetInfoFormViewModel viewModel)
        {
            var scorer = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);

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
        }

        public async Task<Boolean> MemberRoleUpdated()
        {
            var scorer = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);

            var scorerRole = _powerliftDBContext.MemberRoles.Where(user => user.Id == scorer.Id).FirstOrDefault();

            if (scorerRole != null)
            {
                return true;
            }

            return false;
        }
    }
}
