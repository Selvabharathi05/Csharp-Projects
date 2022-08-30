using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Problem_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueClass Q = new QueueClass(5);

            Q.insert(1);
            Q.insert(2);
            Q.insert(3);
            Q.insert(4);
            Q.insert(5);

            Console.WriteLine("Items  : ");
            Q.printQueue();

            Q.delete();
            Q.delete();

            Console.WriteLine("After Deleting Items are : ");
            Q.printQueue();
            Console.ReadLine(); 
        }
    }
}
===========================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Problem_Queue
{
     class QueueClass
    {

        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public QueueClass(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void insert(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        public int delete()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + ele[front]);
                return ele[front++];
            }
        }

        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }

}
