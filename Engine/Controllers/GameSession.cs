using Engine.Models;
using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controllers
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            InitialiseNewSession(CurrentPlayer);

            World CurrentWorld = InitialiseNewWorld();

            InitialiseNewLocation(CurrentWorld);
        }

        private World InitialiseNewWorld()
        {
            WorldFactory factory = new WorldFactory();
            return factory.CreateWorld();
        }

        private void InitialiseNewSession(Player player)
        {
            player.Name = "Varesh";
            player.CharacterClass = "Figher";
            player.Gold = 0;
            player.Level = 1;
            player.HitPoints = 100;
            player.ExperiencePoints = 0;
        }

        private void InitialiseNewLocation(World currentLocation)
        {
            CurrentLocation = currentLocation.LocationAt(0, -1);
        }
    }
}
