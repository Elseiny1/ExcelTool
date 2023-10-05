namespace ExcelTool.Bl.IReposatory
{
    public interface IExcelRepo
    {
        string GetFilePath(IFormFile file);
        IFormFile WriteExcel(IFormFile file);
        
    }
}
