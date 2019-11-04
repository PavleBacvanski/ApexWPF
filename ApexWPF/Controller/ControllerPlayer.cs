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
    public class ControllerPlayer
    {
      
        public bool GetPlayer(string platform, string playerName)
        {
            PlayerApi playerApi = new PlayerApi(Constants.Platform);

            var player = playerApi.GetPlayerByName(platform, playerName);

            Constants.Player = player;

            return player != null;
        }
    }
}
