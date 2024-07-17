using Microsoft.AspNetCore.Mvc;

namespace Routage.Controllers
{
    public class HelloController : Controller
    {

        public string SayHello() => "Hello !";
        public string YellHello() => "HELLOOOOO !";

        [Route("/Say")]
        public string SayHelloAttributes() => "Hello !";

        [Route("/Yell")]
        public string YellHelloAttributes() => "HELLOOOOO !";
    }
}
