namespace DGD.Models
{
    public class Library
    {
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


        //        Library
        //8-Digit SKU
        //SKU Genre
        //SKU Publisher
        //SKU Serires
        //SKU Edition
        //CHAR Genre
        //CHAR Sub
        //Library Quantity
        //Quantity Available
        //Quantity Rented
        //Quantity Pending
       


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
