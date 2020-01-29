using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlazorServerTest.Models  
{  
    [Table("album")]
    public class Album  
    {    
        public int Id { get; set; }  
  
        public string Name { get; set; }  
  
        public string ArtistName { get; set; }  
  
        public int Price { get; set; }  
  
        public string Genre { get; set; }  
    }  
} 