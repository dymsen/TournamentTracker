using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the TournamentName
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the EntryFee for the Tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the EnteredTeams in a list
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents the Prizes in a list
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the Rounds in a list
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
