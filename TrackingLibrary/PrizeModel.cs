
namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The number the team/player actually placed.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// What each placement should be referred to as.
        /// </summary>
        public string PlaceName{ get; set; }

        /// <summary>
        /// The amount of winnings for the placement.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the pot for the placement.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
