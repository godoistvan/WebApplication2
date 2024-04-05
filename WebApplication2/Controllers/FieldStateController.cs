using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WpfApp1.Interfaces;
using WpfApp1.Logic;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldStateController : ControllerBase
    {
        IFieldState fieldstate;
        public FieldStateController(FieldState logic)
        {
            this.fieldstate = logic;
        }
        [HttpGet]
        public void ReadAll()
        {
            this.fieldstate.ShowField();
        }
        [HttpPost]
        public void Create(string player,int fieldnumber)
        {
            this.fieldstate.Draw(player, fieldnumber);
        }
    }
}
