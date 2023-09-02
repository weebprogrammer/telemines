using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace telemines.TelegramSapper.Query
{
    internal interface IQuery
    {
        public void Query(ITelegramBotClient client, Message? message);
    }
}
