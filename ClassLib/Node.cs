using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Node<K, V> : IKeyValuePair<K, V>
    {
        public K Key { get; private set; }
        public V Value { get; set; }
        public Node<K, V> Left { get; set; }
        public Node<K, V> Right { get; set; }

        public Node(K l_key, V l_value)
        {
            Key = l_key;
            Value = l_value;
        }


    }
}
