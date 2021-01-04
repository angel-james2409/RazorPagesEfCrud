using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesEfCrud.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DelieveyTime{ get; set; }
       


    }
}
