namespace DGD.Models
{
    public class Rental
    {
        public int LibraryId { get; set; }


        public int ActiveHolds { get; set; }

        public List<int> OutToCustomer { get; set; }
        public string RentalCategory { get; set; }

        public string Promotions { get; set; }

        public int BuyOffer { get; set; }
        public int CostofGame { get; set; }
        public int CopiesIssued { get; set; }
        public string RentalHistory { get; set; }


    }
}
