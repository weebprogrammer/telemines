using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telemines.TelegramSapper.Query
{
    internal class HelpQuery : IQuery
    {
        public void Query(ITelegramBotClient client, Message? message)
        {
            string helpMessage = "";

            helpMessage += "/gamestart - начать игру\n";
            helpMessage += "/gamestop - завершить игру\n";
            helpMessage += "/choice <value> - выбрать клетку\n";
            helpMessage += "/mark <value> - выбрать марку\n";

            client.SendTextMessageAsync(message.Chat.Id, helpMessage);
        }
    }
}
