using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication2.Services;
using WpfApp1.Interfaces;
using WpfApp1.Logic;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldStateController : ControllerBase
    {
        IFieldState fieldstate;
        IHubContext<SignalRhub> hub;
        public FieldStateController(FieldState logic, IHubContext<SignalRhub> hub)
        {
            this.fieldstate = logic;
            this.hub = hub;
        }
        [HttpGet]
        public void ReadAll()
        {
            this.fieldstate.ShowField();
        }
        [HttpPost]
        public void Create(Player player)
        {
            this.fieldstate.Draw(player);
            this.hub.Clients.All.SendAsync("PlayerDrawn", player);
        }
    }
}
