using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NodeList<string> list = new NodeList<string>("1");
            list.AddLast("2");
            list.AddLast("3");
            list.AddLast("4");

            list.Loop(x => Console.WriteLine(x));

            Console.WriteLine("-------------------------");

            NodeList<int> list2 = new NodeList<int>(1);
            list2.AddLast(2);
            list2.Loop(x => Console.WriteLine(x));

            Console.WriteLine("-------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get;}
        public Node<T> Next { get; set; }    
    }

    class NodeList<T> : IEnumerable
    {
        public NodeList(T headData)
        {
            Head = new Node<T>(headData);
        }
        public Node<T> Head { get; set; }
        public void AddLast(T data)
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node<T>(data);
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }

        public void Loop(Action<T> action)
        {
            Node<T> current = Head;
            while (current != null)
            {
                action(current.Data);

                current = current.Next;
            }
        }
    }
}
