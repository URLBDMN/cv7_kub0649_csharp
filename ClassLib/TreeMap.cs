using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLib
{
    public class TreeMap<K, V> where K : IComparable
    {
        private Node<K, V> root;
      

        private int count = 0;

        public int Count { get { return count; } }

        public TreeMap(Node<K, V> _root)
        {
            root = _root;
            count += 1;
        }


        public V this[K key]
        {
            get
            {
                Node<K, V> tmp = root;
                if (tmp.Key.CompareTo(key) == 0)
                {
                    return tmp.Value;
                }
                while (true)
                {
                    if (tmp is null)
                        return default(V);

                    if (tmp.Key.CompareTo(key) < 0)
                    {

                        tmp = tmp.Right;
                    }
                    else if (tmp.Key.CompareTo(key) > 0)
                    {
                        tmp = tmp.Left;
                    }

                    if (tmp is null)
                        return default(V);

                    if (tmp.Key.CompareTo(key) == 0)
                    {
                        return tmp.Value;
                    }
                }
            }
            set
            {
                Node<K, V> tmp = new Node<K, V>(key, value);
                Node<K, V> current = root;
                while (true)
                {
                    Node<K, V> tempParent = current;
                    if (tempParent.Key.CompareTo(tmp.Key) < 0)
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            tempParent.Right = tmp;
                            count++;
                            return;
                        }

                    }
                    else
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            tempParent.Left = tmp;
                            count++;
                            return;
                        }
                    }
                }


            }

        }

        public IKeyValuePair<K, V>[] ToArray()
        {
            Node<K, V> start;
            Node<K, V> camefrom;
            bool dual = false;

            IKeyValuePair<K, V>[] ikvp = new IKeyValuePair<K, V>[count];

            ikvp[0] = root;

            if (root.Right is null && root.Left is null)
            {
                return ikvp;
            }

            start = root;

            camefrom = root;

            for (int i = 1; i < count; i++)
            {
                if (dual == true)
                {
                    ikvp[i] = camefrom.Right;
                    start = camefrom.Right;
                    dual = false;
                    continue;
                }

                if (start.Left is not null && start.Right is not null )
                {
                    ikvp[i] = start.Left;
                    camefrom = start;
                    dual = true;
                    continue;
                }

                if (start.Left is not null)
                {
                    ikvp[i] = start.Left;
                    start = start.Left;
                }

                if (start.Right is not null)
                {
                    ikvp[i] = start.Right;
                    start = start.Right;
                } 

            }

            return ikvp;
        }

        public void DeleteValueONKey(K key)
        {
            Node<K, V> start;
            Node<K, V> camefrom;
            bool dual = false;


            if (root is null)
            {
                return;
            }

            start = root;
            camefrom = root;

            for (int i = 1; i < count; i++)
            {
                if (start.Key.CompareTo(key) == 0)
                {
                    start.Value = default(V);
                    break;
                }

                if (dual == true)
                {
                      if (camefrom.Right.Key.CompareTo(key) == 0)
                    {
                        camefrom.Right.Value = default(V);
                        break;
                    }
                    start = camefrom.Right;
                    dual = false;
                    continue;
                }

                if (start.Left is not null && start.Right is not null)
                {
                    dual = true;
                    if (start.Left.Key.CompareTo(key) == 0)
                    {
                        start.Left.Value = default(V);
                        break;
                    }
                    else if (start.Right.Key.CompareTo(key) == 0)
                    {
                        start.Right.Value = default(V);
                        break;
                    }
                    else
                    {
                        camefrom = start;
                        continue;
                    }
                }

                if (start.Left is not null)
                {
                    if (start.Left.Key.CompareTo(key) == 0)
                    {
                        start.Left.Value = default(V);
                        break;
                    }
                    start = start.Left;
                }

                if (start.Right is not null)
                {
                    if (start.Right.Key.CompareTo(key) == 0)
                    {
                        start.Right.Value = default(V);
                        break;
                    }
                    else
                    {
                        start = start.Right;
                    }

                }

            }
        }

        
    



        
        public void PrintHLP(Node<K, V> root, int space)
        {
            
            int CONT = 10;
            if (root == null)
                return;
            space += CONT;
            PrintHLP(root.Right, space);
            Console.Write("\n");
            for (int i = CONT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Key.ToString() + "\n");
            PrintHLP(root.Left, space);
        }

        public void PrintTree(Node<K, V> root)
        {
            PrintHLP(root, 0);
        }

    }
}
