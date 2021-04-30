using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using PLPointTrackingSystem.Models.PLM;
using PLPointTrackingSystem.Models.References;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Import(IFormFile file) //STILL NEED TO ADD TO MAP TO DATABASE AS WELL W/LINQ
        {
            var viewModel = new UploadTestViewModel();
            viewModel.FileData = new List<TestData>();

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using(var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;

                    for (int row = 2; row < rowcount; row++)
                    {
                        viewModel.FileData.Add(new TestData
                        {
                            Name = worksheet.Cells[row, 1].Value.ToString().Trim(),
                            City = worksheet.Cells[row,2].Value.ToString().Trim(),
                            Age = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            Food = worksheet.Cells[row, 4].Value.ToString().Trim()
                        });
                    }
                }
            }

            return View("UploadTest", viewModel);
        }

        public IActionResult UploadTest()
        {
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
