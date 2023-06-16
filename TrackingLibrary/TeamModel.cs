using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// List of players on a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of the specific team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
