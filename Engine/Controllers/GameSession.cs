using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controllers
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            InitialiseNewSession(CurrentPlayer);

            CurrentLocation = new Location();
            InitialiseNewLocation(CurrentLocation);
        }

        public GameSession(Player player)
        {
            CurrentPlayer = player;
        }

        private void InitialiseNewSession(Player player) {
            player.Name = "Varesh";
            player.CharacterClass = "Figher";
            player.Gold = 0;
            player.Level = 1;
            player.HitPoints = 100;
            player.ExperiencePoints = 0;
        }

        private void InitialiseNewLocation(Location location)
        {
            location.Name = "Home";
            location.Description = "This is your home, where you can rest";
            location.XCoordinate = 0;
            location.YCoordinate = -1;
            location.ImageName = "/Engine;component/Images/Locations/house.png";
        }
    }
}
