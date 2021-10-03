namespace ServerARM.Models
{
    public class Group
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public string name { get; set; }
        public System.DateTime year {get;set;}
    }
}
