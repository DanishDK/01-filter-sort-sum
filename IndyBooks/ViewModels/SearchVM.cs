using System;
using System.ComponentModel.DataAnnotations;
namespace IndyBooks.ViewModels
{
    public class SearchVM
    {
        [Display(Name = "Title to Find: ")]
        public String Title { get; set; } = "";

        [Display(Name = "Half-Price Sale: ")]
        public Boolean HalfPriceSale { get; set; }
        //TODO: Add properties with Display annotation needed for searching

        [Display(Name = "lastName")]
        public String LastName { get; set;} ="";

        [Display(Name = "Min - Max Value Price: ")]
        public Boolean MinMaxValue { get; set; }
        

    }
}
