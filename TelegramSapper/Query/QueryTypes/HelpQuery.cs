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
            helpMessage += "/choice column <value> - выборать столбец\n";
            helpMessage += "/choice row <value> - выборать строку\n";
            helpMessage += "/mark column <value> - выборать столбец\n";
            helpMessage += "/mark row <value> - выборать строку\n";

            client.SendTextMessageAsync(message.Chat.Id, helpMessage);
        }
    }
}
