using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SongPlayer player = new SongPlayer();
            player.head = new Node("Song1");
            Node second = new Node("Song2");
            Node third = new Node("Song3");
            player.head.next = second;
            second.next = third;
            third.prev = second;
            second.prev = player.head;
            Console.WriteLine("How do you want to play songs, forward or backward? Press 1 for forward playing and 2 for backward playing.");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    player.PlayForward(player.head);
                    break;
                case 2:
                    player.PlayBackward(player.head);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;

            }
            Console.WriteLine("Do you want to add song? Press 1 for yes and 2 for no.");
            int reply = Convert.ToInt32(Console.ReadLine());
            while (reply == 1)
            {
                Console.WriteLine("Enter the song to be added: ");
                String song= Console.ReadLine();
                player.Add("song");
                Console.WriteLine("Do you want to add another song? Press 1 for yes and Press 2 for no.");
                reply = Convert.ToInt32(Console.ReadLine());
            }
            player.PlayForward(player.head);
            Console.WriteLine("Do you want to delete song? Press 1 for yes and Press 2 for no.");
            int response = Convert.ToInt32(Console.ReadLine());
            while (response == 1)
            {
                Console.WriteLine("Enter the song to be deleted: ");
                String song = Console.ReadLine();
                player.Delete(song);
                if (player.head != null){
                    player.PlayForward(player.head);
                }
                else
                {
                    Console.WriteLine("Playlist is now empty!");
                }

                Console.WriteLine("Do you want to delete song? Press 1 for yes and Press 2 for no.");
                response = Convert.ToInt32(Console.ReadLine());
            } 
        }
    }
}
