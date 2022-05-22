using BesikduzuSeyahat.Business.Abstract;
using BesikduzuSeyahat.Data.Abstract;
using BesikduzuSeyahat.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;
        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public void Create(Ticket entity)
        {
            _ticketRepository.Create(entity);
        }

        public void Delete(Ticket entity)
        {
            _ticketRepository.Delete(entity);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public int GetCountBySeat(int directionId)
        {
            return _ticketRepository.GetCountBySeat(directionId);
        }

        public string GetDate(int id)
        {
            return _ticketRepository.GetDate(id);
        }

        public int GetId()
        {
            return _ticketRepository.GetId();
        }

        public Ticket GetLastSave()
        {
            return _ticketRepository.GetLastSave();
        }

        public List<int> GetSeat(int directionId)
        {
            return _ticketRepository.GetSeat(directionId);
        }

        public string GetTime(int id)
        {
            return _ticketRepository.GetTime(id);
        }

        public void Update(Ticket entity)
        {
            _ticketRepository.Update(entity);
        }

        public void Update(Ticket entity, int[] ticketIds)
        {
            //throw new NotImplementedException();
            _ticketRepository.Update(entity, ticketIds);
        }
    }
}
