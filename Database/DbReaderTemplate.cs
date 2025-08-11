using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class DbReaderTemplate<T>
    {
        public List<T> LoadAll()
        {
            Connect();
            var result = ReadData();
            Disconnect();
            return result;
        }

        protected abstract void Connect();
        protected abstract List<T> ReadData();
        protected abstract void Disconnect();
    }
}
