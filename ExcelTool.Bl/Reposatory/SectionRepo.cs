using ExcelDataReader;
using ExcelTool.DAL.Models;

namespace ExcelTool.Bl.Reposatory
{
    public class SectionRepo : ISectionRepo
    {
        readonly private AppDbContext _Context;
        private readonly IExcelRepo _excelTool;
        public SectionRepo(AppDbContext context,IExcelRepo excelTool)
        {
                this._Context = context;
            this._excelTool = excelTool;
        }
        void ISectionRepo.AddSection(string sectionName)
        {
            throw new NotImplementedException();
        }

        List<StoreSction> ISectionRepo.AddSectionList(IFormFile file)
        {
            List<StoreSction> sections = new List<StoreSction>();
            string filePath = _excelTool.GetFilePath(file);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
           using (var stream=File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using(var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        var section = new StoreSction()
                        {
                            Name = reader.GetValue(2).ToString(),
                        };

                        _Context.Add(section);
                        sections.Add(section);

                    }
                }
            }
            _Context.SaveChanges();
            return sections;
        }

        List<StoreSction> ISectionRepo.GetAllSections()
        {
            throw new NotImplementedException();
        }
    }
}
