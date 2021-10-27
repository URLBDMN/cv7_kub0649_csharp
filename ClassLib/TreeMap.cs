using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    class TreeMap<K,V> where K : IComparable 
    {
        private Node<K,V> root;

        private int count;

        public V this[K index]
        {
            get
            {
                while (true)
                {
                    if (index > root.Key)
                    {

                    }


                } 
            
            
            }
            set { root.Value = value; }
        }



        public int Count
        {
            get { return count; }
        }


        public TreeMap()
        {

        }


    }
}
