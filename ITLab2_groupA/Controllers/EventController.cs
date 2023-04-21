using ITLab2_groupA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITLab2_groupA.Controllers
{
    public class EventController : Controller
    {
        private static List<EventModel> events = new List<EventModel>
        {
            new EventModel(){Id = 1, Name = "Graduation", Location = "Macedonia"},
            new EventModel(){Id = 2, Name = "Starting work", Location = "Serbia"},
            new EventModel(){Id = 3, Name = "Marriage", Location = "Greece"}
        };
        // GET: Event
        public ActionResult ShowEvents()
        {
            return View(events);
        }

        public ActionResult AddNewEvent(EventModel newEvent)
        {
            if (ModelState.IsValid)
            {
                int newId = events.Any() ? events.Max(e => e.Id) + 1 : 1;
                newEvent.Id = newId;
                events.Add(newEvent);
                return RedirectToAction("EventDetails", new { id = newId });
            }

            else
            {
                return View(newEvent);
            }
        }

        public ActionResult EventDetails(string name)
        {
            var model = events.LastOrDefault();
            return View(model);
        }

        public ActionResult EditEvent(int id)
        {
            EventModel eventToEdit = events.LastOrDefault(e => e.Id == id);

            if(eventToEdit == null)
            {
                return HttpNotFound();
            }

            return View(eventToEdit);
        }

        [HttpPost]
        public ActionResult EditEvent(EventModel eventToEdit)
        {
            if (ModelState.IsValid)
            {
                int index = events.FindIndex(e => e.Id == eventToEdit.Id);

                if(index == -1)
                {
                    return HttpNotFound();
                }

                events[index] = eventToEdit;

                return RedirectToAction("ShowEvents");
            }

            return View(eventToEdit);
        }

        public ActionResult DeleteEvent(int id)
        {
            EventModel eventToDelete = events.LastOrDefault(e => e.Id == id);

            if(eventToDelete == null)
            {
                return HttpNotFound();
            }

            return View(eventToDelete);
        }

        [HttpPost, ActionName("DeleteEvent")]
        public ActionResult ConfirmDeletion(int id)
        {
            int index = events.FindIndex(e => e.Id == id);

            if(index == -1)
            {
                return HttpNotFound();
            }

            events.RemoveAt(index);

            for(int i = 0; i < events.Count; i++)
            {
                events[i].Id = i + 1;
            }

            return RedirectToAction("ShowEvents");
        }
    }
}