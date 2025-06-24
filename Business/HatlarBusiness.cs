using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class HatlarBusiness : IHatlarBusiness
    {
        private readonly IHatlarRepository _hatlarRepository;
        public HatlarBusiness(IHatlarRepository hatlarRepository)
        {
            _hatlarRepository = hatlarRepository;
        }
        public List<Hatlar> HatlarListele()
        {
            return _hatlarRepository.HatlarListele();
            //throw new NotImplementedException();
        }
    }
}
