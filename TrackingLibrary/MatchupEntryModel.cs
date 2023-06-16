
namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// One team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// The score for the specific team.
        /// </summary>
        public double Score{ get; set; }

        /// <summary>
        /// Previous mathcup that the team won.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
