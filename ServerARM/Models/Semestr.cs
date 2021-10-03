namespace ServerARM.Models
{
    public class Semestr
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public int number { get; set; }
        public System.DateTime year { get; set; }
    }
}
