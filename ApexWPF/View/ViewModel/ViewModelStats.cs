using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.View.ViewModel
{
    public class ViewModelStats
    {
        public string PlayerName { get; set; }
        public string CountryCode { get; set; }
        public string Kills { get; set; }
        public string Icon { get; set; }
        public string Legend { get; set; }
        public string LegendIcon { get; set; }
        public float Level { get; set; }
        public int Season { get; set; }
        public string Platform { get; set; } 

        public ViewModelStats(string icon, string playerName, string countryCode, string kills, string legendIcon,
            string legend, float level, int season, string platform) 
        {
            PlayerName = playerName;
            CountryCode = countryCode;
            Kills = kills;
            Icon = icon;
            Legend = legend;
            Level = level;
            LegendIcon = legendIcon;
            Season = season;
            Platform = platform;
        }
    }
}
