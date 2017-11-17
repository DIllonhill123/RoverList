using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        int count;
        Node Temp;
        //private Node tail;

        public RoverList ()
        {
            count = 0;
            head = null;
            //tail = null;
        }

        public override int Count => count;

        public override void Add(object data)
        {
            if(head == null)
            {
                head = new Node(data);
                current = head;
                count++;
            }
            else
            {
                current.Next = new Node(data);
                current = current.Next;
                count++;
            }
            while(current.Next != null)
            {
                current = current.Next;
            }
        }

        public override void Add(int Position, object data)
        {
            current = head;

            if(Position == 0)
            {
                head = new Node(data);
                head.Next = current.Next;
            }
            else
            {
                for (int i = 0; i < Position - 1; i++)
                {
                    current = current.Next;
                }

                Temp = current.Next;
                current.Next = new Node(data);
                current = current.Next;
                current.Next = Temp;
                
            }
            count++;
            while (current.Next != null)
            {
                current = current.Next;
            }
        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }
        

        public override Node ElementAt(int Position)
        {
            current = head;
            int counter = 0;

            if(Position < 0 || Position > Count)
            {
                Node node = new Node(null);
                return node;
            }
            else
            {
                while(counter <= Position - 1)
                {
                    current = current.Next;
                    counter++;
                }
                return current;

            }
        }

        public override void ListNodes()
        {
            Node node = head;
            
            while(node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            
        }

        public override bool RemoveAt(int Position)
        {
            current = new Node("FAKE");
            current.Next = head;
            Temp = null;
            int index = 0;

            while (index <= Position && current != null)
            {
                if (index == Position)
                {
                    // Remove current.next
                    if (current.Next == head)
                        head = current.Next.Next;

                    current.Next = current.Next.Next;

                    current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    count--;
                    return true;
                }
                current = current.Next;
                index++;
            }


            current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            return false;

            /*
            if (Position == 0)
            {
                Temp = head.Next;
                head = null;
                head = Temp;
                count--;
            }
            if(Position - 1 == Count - 1)
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current = null;
                count--;
                

            }
            else
            {
                for (int i = 0; i < Position - 1; i++)
                {
                    current = current.Next;
                }
                Temp = current.Next.Next;
                current.Next = null;
                current.Next = Temp;
                count--;
                while (current.Next != null)
                {
                    current = current.Next;
                }
            }
            //count--;

            return true;
            */
        }
    }
}
