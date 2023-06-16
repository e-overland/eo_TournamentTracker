using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// List of teams in the Matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winner for the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The round the mathcup occurred in.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
