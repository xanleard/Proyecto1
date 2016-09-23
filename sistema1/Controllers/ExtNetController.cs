using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;
using sistema1.Models;

namespace sistema1.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult Index()
        {
            ExtNetModel model = new ExtNetModel()
            {
                Title = "COMANDOS A REALIZAR",
                TextAreaEmptyText = ">> Enter a Message Here <<"
            };

            return this.View(model);
        }

        public ActionResult SampleAction(string message)
        {
            X.Msg.Notify(new NotificationConfig
            {
                Icon = Icon.Accept,
                Title = "LOGOUT",
                Html = message
            }).Show();



            return this.Direct();
        }
    }
}