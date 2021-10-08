using System;
using System.ComponentModel.DataAnnotations;

namespace Crudelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required]
        [MinLength(2)]
        public string DishName {get;set;}
        
        public int Tastiness {get;set;}
        public int Calories {get;set;}
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}