using Observer_Pattern.Concrete;
using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configure Observer pattern
            ConcreteChatRoom ChatRoom = new ConcreteChatRoom();

            ChatRoom.Attach(new ConcreteUser(ChatRoom, "Justin"));
            ChatRoom.Attach(new ConcreteUser(ChatRoom, "Mark"));

            //We change state and thus we notify all attached users.
            ChatRoom.State = "Chat Room Started.";
            Console.WriteLine(ChatRoom.State);

            //TODO:
            //For example. Justin messaged in the Chat Room.


            //For example. 
            ChatRoom.State = "State 1";

            var user1 = ChatRoom.GetUser("Mark");
            var user2 = ChatRoom.GetUser("Justin");

            //Console.WriteLine(user1.Message, "Mark's message {0}");
            //Console.WriteLine(user2.Message, "Justins recieved/sent message {0}");

            //For Example. Get Justin user from ChatRoom and display name.
            Console.WriteLine(ChatRoom.GetUser("Justin").Name + " Here");
        }


    }
}
