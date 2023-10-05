namespace ExcelTool.DAL.Models
{
    public class StoreSction
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
