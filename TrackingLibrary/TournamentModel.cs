using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Entry fee if there is one.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams participating in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes for each placement in the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of rounds for the tournament and the respective mathcups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
