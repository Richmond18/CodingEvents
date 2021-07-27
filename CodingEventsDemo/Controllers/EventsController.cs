using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
        public Dictionary<string, string> eventD = new Dictionary<string, string> { };
 

        // GET: /<controller>/

        // can i add the dictionary here?
        //example public string Name {get; srt} = "r";
        static private IActionResult Index(string Discription, string concert)
        {
            List<string> Events = new List<string>();
            Events.Add("EDC");
            Events.Add("COACHELLA");
            Events.Add("Strange Loop");

            ViewBag.events = Events;


            foreach (var Eventss in ViewBag.Events)
            {
                eventD.Add(Eventss, "");
            }


            //ViewBag.eventdis = Discription;

          //  if (concert == "EDC")
           // {
                //ViewBag.eventdis = Discription;
                //ViewBag.eventDic = eventD;
                //ViewBag.storedD= this.Name;

               // for (int i = 0; i< concert.Length; ++i )
                //foreach (var compare in eventD)
                    //if (concert == compare.Key)
                    if (eventD.ContainsKey("EDC"))
                    {

                    eventD.Add("keyy", Discription);
                        // eventD.Remove(compare.Key);
                        // eventD.Add(compare.Key, Discription);
                }
            //}

            ViewBag.eventDd = this.eventD;
            return View();



        }

        public IActionResult EventDiscription()
       

        {

            //     if (concert == "EDC")
            //     {
            //         ViewBag.eventdis = Discription;
            //         //ViewBag.eventDic = eventD;
            //         //ViewBag.storedD= this.Name;

            //         foreach (var compare in eventD)
            //            //if (concert == compare.Key)
            //            if (eventD.ContainsKey(compare.Key))
            //                 {
            //                 eventD.Remove(compare.Key);
            //                 eventD.Add(compare.Key, Discription);
            //             }


            //     }

            ViewBag.eventDd = this.eventD;


            return View();



        }



    }


}
