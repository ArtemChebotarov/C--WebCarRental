using Kolokwium2_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2_test.DAL
{
    public interface IDBLayer
    {
        IEnumerable<Player> GetPlayers();
        IEnumerable<Team> GetTeams();

        void AddNewPlayer(Player newPlayer);
    }
}
