using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telemines.TelegramSapper.Query
{
    internal class GameStartQuery : IQuery
    {
        public void Query(ITelegramBotClient client, Message? message)
        {
            client.SendTextMessageAsync(message.Chat.Id, "Игра началась!");

            string field =
                "A B C D E F G H\n" +
                "# # # # # # # # - 1\n" +
                "# # # # # # # # - 2\n" +
                "# # # # # # # # - 3\n" +
                "# # # # # # # # - 4\n" +
                "# # # # # # # # - 5\n" +
                "# # # # # # # # - 6\n" +
                "# # # # # # # # - 7\n" +
                "# # # # # # # # - 8\n";

            client.SendTextMessageAsync(message.Chat.Id, message.Chat.Id.ToString());
            client.SendTextMessageAsync(message.Chat.Id, field);        
        }
    }
}
