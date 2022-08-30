using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Problem_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            LinkedListclass<string> stringLinkedList = new LinkedListclass<string>();
            string s1 = "Hello";
            string s2 = "all";
            string s3 = "Welcome";
            string s4 = " to C#";
            stringLinkedList.AddHead(s1);
            stringLinkedList.AddHead(s2);
            stringLinkedList.AddHead(s3);
            stringLinkedList.AddHead(s4);
            foreach (string str in stringLinkedList)
            {
                Console.WriteLine(str);
            }


            Console.ReadKey();

        }
    }
}
========================================================================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Problem_list
{
    internal class listclass
    {
    }
    class LinkedListclass<T>
    {
        class LinkedlistNode
        {
            private LinkedlistNode next;
            private T item;

            public LinkedlistNode(T t)
            {
                next = null;
                item = t;

            }
            public LinkedlistNode Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public T Item
            {
                get
                {
                    return item;
                }
                set
                {
                    item = value;
                }
            }
        }
        private LinkedlistNode head;
        public LinkedListclass()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            LinkedlistNode node = new LinkedlistNode(t);
            node.Next = head;
            head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedlistNode current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }

        }

    }
}
