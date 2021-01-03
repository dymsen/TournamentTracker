using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the Entries of the Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the Winner of the Matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the MatchupRound
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
