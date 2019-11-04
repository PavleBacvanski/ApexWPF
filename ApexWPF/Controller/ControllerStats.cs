using ApexWPF.API;
using ApexWPF.Model;
using ApexWPF.Utils;
using ApexWPF.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexWPF.Controller
{
    public class ControllerStats
    {
        public object GetContext()
        {
            var player = Constants.Player;

            
            return new ViewModelStats(player.data.platformInfo.avatarUrl, player.data.platformInfo.platformUserIdentifier, player.data.userInfo.countryCode,
                player.data.segments[1].stats.kills.displayValue, player.data.segments[1].metadata.imageUrl, player.data.metadata.activeLegendName,
                player.data.segments[0].stats.level.value, player.data.metadata.currentSeason, player.data.platformInfo.platformSlug);
        }

        //private StatsModel GetStats(PlatformInfo player)
        //{
        //    StatsApi stats = new StatsApi(Constants.Platform);

        //    var position = stats.GetModels(player.platformSlug, player.platformUserIdentifier);

        //    return position ?? new StatsModel();
        //}
    }
}
