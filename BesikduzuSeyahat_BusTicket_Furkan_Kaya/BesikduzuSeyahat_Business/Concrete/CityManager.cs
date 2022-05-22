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
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;
        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public string CityName()
        {
            //throw new NotImplementedException();
            return _cityRepository.CityName();//Değiştirilebilir Gözden kaçmasın(silebilirsin bir ihtimal.)
        }

        public void Create(City entity)
        {
            _cityRepository.Create(entity);
        }

        public void Delete(City entity)
        {
            _cityRepository.Delete(entity);
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(int id)
        {
            return _cityRepository.GetById(id);
        }

        public void Update(City entity)
        {
            _cityRepository.Update(entity);
        }

        public void Update(City entity, int[] cityIds)
        {
            //throw new NotImplementedException();
            _cityRepository.Update(entity, cityIds);
        }
    }
}
