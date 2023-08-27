namespace telemines;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using telemines.TelegramSapper;

class Program
{
    static void Main(string[] args)
    {
        TelegramBotClient client = new TelegramBotClient("6590579648:AAGZdelqyu07O5n1rEIJI7THU-v3dphOnvo");
        client.StartReceiving(Update, Error);
        Console.ReadLine();
    }

    private static void RegisterQuery<QueryT>(string name, ref Dictionary<string, object> QueriesTable) where QueryT : new()
    {
        QueriesTable.Add(name, new QueryT());
    }

    private static IQuery GetQueryObject(string name, ref Dictionary<string, object> QueriesTable)
    {
        return (IQuery)QueriesTable[name];
    }

    async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
    {
        Message? message = update.Message;

        if (message.Text == null)
            return;

        Console.WriteLine(message.Chat.FirstName + "\t || \t" + message.Text);
        QueryManager manager = new QueryManager(client, message);
        var QueriesTable = new Dictionary<string, object>();

        RegisterQuery<StartQuery>("/start", ref QueriesTable);
        RegisterQuery<GameStartQuery>("/gamestart", ref QueriesTable);
        RegisterQuery<GameStopQuery>("/gamestop", ref QueriesTable);
        RegisterQuery<ChoiceQuery>("/choice", ref QueriesTable);
        RegisterQuery<MarkQuery>("/mark", ref QueriesTable);
        RegisterQuery<HelpQuery>("/help", ref QueriesTable);

        string m = message.Text.ToLower();
        
        await Task.Run(() => manager.Query(GetQueryObject(m, ref QueriesTable)));
    }

    async static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        
    }
}
