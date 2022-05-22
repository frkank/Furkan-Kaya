using BesikduzuSeyahat.Business.Abstract;
using BesikduzuSeyahat.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BesikduzuSeyahat.WebUI.Controllers
{
    public class UserController : Controller
    {
        private ITicketService _ticketService;
        public UserController(ITicketService biletService)
        {
            this._ticketService = biletService;
        }
        public IActionResult AdminList()
        {
            return View(new DirectionTicket()
            {
                Tickets = _ticketService.GetAll()
            });
        }

        public IActionResult CancelTicket(int ticketId)
        {
            var ticket = _ticketService.GetById(ticketId);
            if (ticket != null)
            {
                _ticketService.Delete(ticket);
            }
            return RedirectToAction("AdminList");
        }
    }
}
