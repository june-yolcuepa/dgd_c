using System.ComponentModel.DataAnnotations;

namespace DGD.Models
{
    public class Library
    {
        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }

        public int TotalQuantity { get; set; }

        public int QuantityAvailable { get; set; }

        public int QuantityRented { get; set; }

        public int QuantityPending { get; set; }


        public int DGDSku { get; set; }

        public int DGDGenre { get; set; }

        public int DGDPublisher { get; set; }

        public int Series { get; set; }
        public int Edition { get; set; }

        public string Genre { get; set; }

        public string Subgenre { get; set; }
       


        //For Customer System Recall
        //Initial Duration Category List
        //Added Days number
        //Discounts System Recall
        //Price       System Recall
        //Days overdue        System Recall
        //Promotions text / short
        //NOTES       text / long
    }
}
