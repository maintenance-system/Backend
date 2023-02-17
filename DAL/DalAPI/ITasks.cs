using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalAPI
{
    public interface ITasks<T>
    {
        //creat
        public int Creat(T item);
        
        //Read
        public List<T> Read();

        //Update
        public bool Update(T item);
    }
}
