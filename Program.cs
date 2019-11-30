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
            ChatRoom.Attach(new ConcreteUser(ChatRoom, "Marl"));

            //We change state and thus we notify all attached users.
            ChatRoom.State = "Chat Room Started.";
            Console.WriteLine(ChatRoom.State);

            //For example. Justin messaged in the Chat Room.
            Console.WriteLine(ChatRoom.GetUser("Justin").Name);
        }


    }
}
