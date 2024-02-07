using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Node
    {
        public Node head = null;
        public Object obj = null;
        public Node tail = null;
    }
    public class SinglyLinkedList
    {
        private Node permanent = new Node();
        public void Add(Object obj)
        {
            Node temp = permanent;
            while (temp.tail != null)
            {
                temp = temp.tail;
            }
            Node NewNode = new Node();
            temp.obj = obj;
            temp.tail = NewNode;
            NewNode.head = temp;
        }
        public void Display()
        {
            Node bot = permanent;
            while (bot.tail != null)
            {
                Console.WriteLine(bot.obj);
                bot = bot.tail;
            }

        }
        public Object get(int index)
        {

            int start = 0;
            Node bottom = permanent;

            while (start < index && bottom.tail != null)
            {
                bottom = bottom.tail;
                start++;

            }
            Console.WriteLine(bottom);
            if (bottom.obj == null)
            {
                throw new IndexOutOfRangeException("index out of range bound");
            }

            return bottom.obj;
        }
        public void deleteByIndex(int index)
        {
            int start = 0;
            Node bottom = permanent;

            while (start < index && bottom.tail != null)
            {
                bottom = bottom.tail;
                start++;

            }
            Node todelete = bottom.tail;
            bottom.tail = todelete.tail;
            todelete.tail.head = bottom;

        }

    }
}
