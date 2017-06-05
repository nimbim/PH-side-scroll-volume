using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHnewnew
{
    class BlockRandomizer
    {
        private uint[] _TypeCount = new uint[4];
        private Random _rnd;

        public BlockRandomizer()
        {
            _rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                _TypeCount[i] = 0;
            }
        }

        public int NextBlockType()
        {
            if (_TypeCount[0] < 3)
            {
                _TypeCount[0]++;
                return 1;
            }
            else
            {
                int index = _rnd.Next(0, 4);
                
                if(index != 0)
                {
                    _TypeCount[0] = 0;
                }
                _TypeCount[index]++;
                if(_TypeCount[index] == 2)
                {
                    _TypeCount[index] = 0;
                    return _rnd.Next(2, 4);
                }
                return index + 1;
            }
        }
    }
}
