using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telemines.TelegramSapper
{
    internal class MarkQuery : IQuery
    {
        public void Query(ITelegramBotClient client, Message? message)
        {
            client.SendTextMessageAsync(message.Chat.Id, "Выбрана марка ...");
        }
    }
}
