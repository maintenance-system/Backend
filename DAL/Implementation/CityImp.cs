using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.DataObjects;

namespace DAL.Implementation
{
    public class CityImp : ITasks<City>
    {
        public int Creat(City item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(City item)
        {
            throw new NotImplementedException();
        }

        public List<City> Read()
        {
            List<City> Cities;
            using (DBContext db = new())
            {
                Cities = db.Cities.ToList();
            }
            return Cities;
        }

        public bool Update(City item)
        {
            throw new NotImplementedException();
        }

       
    }
}
