using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telemines.TelegramSapper.State
{
    class Board { };

    internal class State
    {
        private readonly long chatID;
        private Board board;

        public Board Board 
        {
            get 
            {
                Reading();
                return board; 
            }

            set
            { 
                board = value;
                Writing();
            }
        }

        public State(long chatID)
        {
            this.chatID = chatID;
        }

        private void Writing()
        {
            return;
        }

        private void Reading()
        {
            return;
        }
    }
}
