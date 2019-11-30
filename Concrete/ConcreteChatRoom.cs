using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern.Concrete
{
    public class ConcreteChatRoom : ChatRoom
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        
    }
}
