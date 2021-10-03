namespace ServerARM.Models
{
    public class Item
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
