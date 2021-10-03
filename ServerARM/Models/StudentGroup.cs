namespace ServerARM.Models
{
    public class StudentGroup
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public string FIO { get; set; }
        public int idGroup { get; set; }
    }
}
