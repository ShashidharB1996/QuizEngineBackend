using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace QuizServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private IHubContext<QuestionHub> _questionHubContext;

        public QuestionController(IHubContext<QuestionHub> questionHubContext)
        {
            _questionHubContext = questionHubContext;
        }

        public IActionResult Post()
        {
            //Broadcast message to client  
           // Dictionary<int,List<options>> quesstions = new Dictionary<int,List<object>>();
            //List<options> list = new List<options>();
            //questions.Add(1,)
            Console.WriteLine("INSIDE POST");
            _questionHubContext.Clients.All.SendAsync("send", "This is a question");

            return Ok();
        }
/*         public IActionResult Get()
        {
            Console.WriteLine("inside get");
            _questionHubContext.Clients.All.SendAsync("recieve", "form the server");
            return Ok();
        } */
    }
}