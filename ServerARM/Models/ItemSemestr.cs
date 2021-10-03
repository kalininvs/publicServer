namespace ServerARM.Models
{
    public class ItemSemestr
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public int idSemestr { get; set; }
        public int idItem { get; set; }
    }
}
