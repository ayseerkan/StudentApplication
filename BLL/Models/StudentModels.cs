namespace BLL.Models;

public partial class StudentModels
{
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public DateTime? birthday { get; set; }
    public int gpa { get; set; }
}