using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public interface IKeyValuePair<K,V>
    {
        K Key {get;}
        V Value {get;}

    }
}
