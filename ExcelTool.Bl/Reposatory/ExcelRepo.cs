using ExcelTool.Bl.IReposatory;


namespace ExcelTool.Bl.Reposatory
{
    public class ExcelRepo : IExcelRepo
    {
        public string GetFilePath(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ExcelFiles");

                // التأكد من وجود المجلد
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                string filePath = Path.Combine(uploadsFolder, fileName);

                return filePath;
            }

            return null;
        }

        IFormFile IExcelRepo.WriteExcel(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
