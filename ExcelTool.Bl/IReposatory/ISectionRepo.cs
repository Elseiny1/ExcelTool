

namespace ExcelTool.Bl.IReposatory
{
    public interface ISectionRepo
    {
        void AddSection(string sectionName);
        List<StoreSction> AddSectionList(IFormFile file);
        List<StoreSction> GetAllSections();
    }
}
