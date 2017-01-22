using Championships.Data;
using Championships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Championships.Controllers
{
    public class PlayerController : ApiController
    {
        private readonly ChampionshipsContext _context;

        public PlayerController(ChampionshipsContext context)
        {
            _context = context;
        }

        public async Task PostAsync([FromBody]string name)
        {
            var player = new Player { Name = name };

            _context.Players.Add(player);
            await _context.SaveChangesAsync();
        }
    }
}
