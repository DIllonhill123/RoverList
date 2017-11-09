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
        public RoverList ()
        {

        }

        public override int Count => throw new NotImplementedException();

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
        }

        public override void Clear()
        {
            head = null;
        }
        

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            current = head;
            
             
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
                
            }
            
        }

        public override bool RemoveAt(int Position)
        {
            current = head;
            Temp = null;
             
            for(int i = 0; i < Position - 1; i++)
            {
                current = current.Next;
                
            }
            Temp = current.Next;
            current = null;
            current = Temp;




            return true;
        }
    }
}
