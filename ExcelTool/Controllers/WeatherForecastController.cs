using Microsoft.AspNetCore.Mvc;
using ExcelTool.Bl.IReposatory;

namespace ExcelTool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ISectionRepo sectionRepo;
        public WeatherForecastController(ISectionRepo _sectionRepo)
        {
            this.sectionRepo = _sectionRepo;
        }
       [HttpPost]
       public async Task<IActionResult> UploadSectionfile(IFormFile file)
        {
            string filename = file.Name;
            if (filename != null)
            {
                var excelFile = sectionRepo.AddSectionList(file);
                return Ok(excelFile);
            }
            else return NotFound(filename);
        }

    }
}