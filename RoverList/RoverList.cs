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
            }
            else
            {
                current.Next = new Node(data);
                current = current.Next;
            }
        }

        public override void Add(int Position, object data)
        {
            current = head;
            for(int i = 0; i < Position; i++)
            {
                current.Next = current;
            }
            current = null;
            Add(data);
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
            throw new NotImplementedException();
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
