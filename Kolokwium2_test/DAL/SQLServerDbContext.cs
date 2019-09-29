using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2_test.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2_test.DAL
{
    public class SQLServerDbContext : IDBLayer
    {
        private readonly PlayerDbContext _context;
        public SQLServerDbContext (PlayerDbContext context)
        {
            _context = context;
        }

        public void AddNewPlayer(Player newPlayer)
        {
            _context.Players.Add(newPlayer);
            _context.SaveChanges();
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players
                .Include(p => p.Team)
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName)
                .ToList();
        }

        public IEnumerable<Team> GetTeams()
        {
            return _context.Teams.OrderBy(t => t.Name).ToList();
        }
    }
}
