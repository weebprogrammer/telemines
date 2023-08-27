using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace telemines.TelegramSapper
{
    internal class StartQuery : IQuery
    {
        public void Query(ITelegramBotClient client, Message? message)
        {
            client.SendTextMessageAsync(message.Chat.Id, "Для ознакомления напишите /help");
        }
    }
}
