namespace Lab1MVCApp_Sanchez.Models
{
    public class Student
    {
        public int    Id         { get; set; }
        public string Name       { get; set; } = string.Empty;
        public string Program    { get; set; } = string.Empty;


        public string Email      { get; set; } = string.Empty;
        public string Address    { get; set; } = string.Empty;
        public string Gender     { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
    }
}
