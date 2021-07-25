using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using PLPointTrackingSystem.DALModels;
using PLPointTrackingSystem.Models.PLM;
using PLPointTrackingSystem.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly PowerliftDBContext _powerliftDBContext;

        public FileUploadController(PowerliftDBContext powerliftDBContext)
        {
            _powerliftDBContext = powerliftDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Import(IFormFile file, int id) 
        {
            var meetInfo = _powerliftDBContext.Meets.Where(meet => meet.MeetID == id).FirstOrDefault();
            var viewModel = new UploadReviewViewModel();
            viewModel.FileData = new List<Athlete>();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using(var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;

                    for (int row = 2; row < rowcount; row++)
                    {
                        _powerliftDBContext.Athletes.Add(new AthletesDAL
                        {
                            //user will need to have data formatted in a very specific way
                            MemberID = worksheet.Cells[row, 1].Value.ToString().Trim(),
                            Name = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            Club = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            WeightClass = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            LifterDivisions = worksheet.Cells[row, 5].Value.ToString().Trim(),
                            Gender = worksheet.Cells[row, 6].Value.ToString().Trim(),
                            Age = worksheet.Cells[row, 7].Value.ToString().Trim(),
                            Squat_Opener = worksheet.Cells[row, 8].Value.ToString().Trim(),
                            Bench_Opener = worksheet.Cells[row, 9].Value.ToString().Trim(),
                            Deadlift_Opener = worksheet.Cells[row, 10].Value.ToString().Trim(),
                            MeetID = id,
                            WeighIn = worksheet.Cells[row, 11].Value.ToString().Trim()
                        });

                        _powerliftDBContext.SaveChanges();

                    }
                }
            }

            viewModel.FileData = _powerliftDBContext.Athletes.Select(athlete => new Athlete()
            {
                Name = athlete.Name,
                MemberID = athlete.MemberID,
                Club = athlete.Club,
                WeightClass = athlete.WeightClass,
                DivisionString = athlete.LifterDivisions,
                Gender = athlete.Gender,
                Age = athlete.Age,
                Squat_Opener = athlete.Squat_Opener,
                Bench_Opener = athlete.Bench_Opener,
                Deadlift_Opener = athlete.Deadlift_Opener,
                MeetID = id

            }).ToList();

            viewModel.FileUploaded = true;

            meetInfo.AthleteDataUploaded = true;
            _powerliftDBContext.SaveChanges();
            return View("UploadReview", viewModel);
        }

        public IActionResult RevertUpload() //send to upload review page but make sure page shows nothing
        {
            //delete database content
            //add (if list.count !=0 to uploadreview view)
            return View();
        }

        //[HttpPost("FileUpload")]
        //public async Task<IActionResult> UploadAthleteData(IFormFile file)
        //{
        //    var size = file.Length;
        //    var filePath = Directory.GetCurrentDirectory();

        //    if (size > 0)
        //    {
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {

        //            await file.CopyToAsync(stream);
        //        }

        //    }

        //    return Ok(new { file, size, filePath });
        //}


    }
}
