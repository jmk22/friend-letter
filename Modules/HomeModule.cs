using Nancy;

namespace FriendLetterApp
{

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters => View["hello.html"];
            Get["/favorite_photos"] = parameters => View["favorite_photos.html"];
            Get["/form"] = parameters => View["form.html"];
        }
    }
}
