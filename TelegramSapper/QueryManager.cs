using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telemines.TelegramSapper
{
    internal class QueryManager
    {
        ITelegramBotClient client;
        Message? message;

        public QueryManager(ITelegramBotClient client, Message? message)
        {
            this.client = client;
            this.message = message;
        }

        public void Query(IQuery query)
        {
            query.Query(client, message);
        }
    }
}
