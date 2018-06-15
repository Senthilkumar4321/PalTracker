using Microsoft.AspNetCore.Mvc;
using PalTracker;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        public WelcomeMessage _message{get;set;}

        public WelcomeController(WelcomeMessage Message){
            _message=Message;
        }

        [HttpGet]
        public string SayHello()=>"hello";

        [HttpGet]
        public string RandController(){
            return _message.Message;
        }
    }
  [Route("/End")]
      public class EndController : ControllerBase
    {
        [HttpGet]
        public string SaySomething()=>"Bye!";
    }
}