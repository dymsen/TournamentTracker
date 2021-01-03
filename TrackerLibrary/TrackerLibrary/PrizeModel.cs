using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the Place Number 
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the PlaceName
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the PrizeAmount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the PrizePercentage 
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
