using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public string SayHello()=>"hello";
    }
  [Route("/End")]
      public class EndController : ControllerBase
    {
        [HttpGet]
        public string SaySomething()=>"Bye!";
    }
}