using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telemines.TelegramSapper.Query
{
    internal class MarkQuery : IQuery
    {
        public void Query(ITelegramBotClient client, Message? message)
        {
            if (message.Text.Length < 9)
            {
                client.SendTextMessageAsync(message.Chat.Id, "Неправильный ввод!");
                return;
            }

            char x = message.Text[8];
            char y = message.Text[9];

            client.SendTextMessageAsync(message.Chat.Id, "Выбрана марка - " + x + ", " + y);
        }
    }
}
