using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class ListMainClass
    {
        static void Main()
        {
            LinkedList<int> li=new LinkedList<int>();
            li.AddFirst(56);
            li.AddFirst(30);
            li.AddFirst(70);
            //SinglyLinkedList l=new SinglyLinkedList ();
            //l.Add(56);
            //l.Add(30);
            //l.Add(70);
            //l.Display();
        }
    }
}
