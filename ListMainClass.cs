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
            SinglyLinkedList l=new SinglyLinkedList ();
            l.Add(56);
            l.Add(30);
            l.Add(70);
            l.Display();
        }
    }
}
