using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfDLL
{
    internal class SongPlayer
    {
            public Node head;
            public void Add(String data)
            {
                Node newnode = new Node(data);
                if (head == null)
                {
                    head = newnode;
                }
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
                newnode.prev = temp;
            }
        public void Delete(string data)
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is empty!");
                return;
            }

            Node temp = head;

            // Traverse list to find the node
            while (temp != null && temp.data != data)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Song not found!");
                return;
            }
            if (temp == head)
            {
                head = head.next;
                if (head != null)   
                    head.prev = null;

                Console.WriteLine($"Deleted: {data}");
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            temp.prev.next = temp.next;

            Console.WriteLine($"Deleted: {data}");
        }

        public void PlayForward(Node head)
            {
                Console.WriteLine("Forward Playing: ");
                while (head != null)
                {
                    Console.Write(head.data + "  ");
                    head = head.next;
                }
                Console.WriteLine();
            }
            public void PlayBackward(Node head)
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty!");
                    return;
                }
                while (head.next != null)
                {
                    head = head.next;
                }
                Console.WriteLine("Backward Playing: ");
                while (head != null)
                {
                    Console.Write(head.data + "  ");
                    head = head.prev;
                }
                Console.WriteLine();
            }

        }

    }
 
