using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaAPI.Classes
{
    public class QueryParameters
    {
        const int _maxSize = 50;
        private int _size = 25;

        public int Page { get; set; }
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = Math.Min(_maxSize, value);
            }
        }
    }
}
