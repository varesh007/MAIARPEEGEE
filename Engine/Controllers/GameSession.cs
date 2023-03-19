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

        public GameSession()
        {
            CurrentPlayer = new Player();
            InitialiseNewSession(CurrentPlayer);
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
    }
}
