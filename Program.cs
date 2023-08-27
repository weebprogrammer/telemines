namespace telemines;

using System;
using System.Data;
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

    async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
    {
        Message? message = update.Message;

        if (message.Text == null)
            return;

        Console.WriteLine(message.Chat.FirstName + "\t || \t" + message.Text);
        QueryManager manager = new QueryManager(client, message);

        await Task.Run(() => manager.Query(CommandType(message.Text.ToLower())));
    }

    async static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        
    }

    public static IQuery CommandType(string command)
    {
        // Start
        if (command.Contains("/start"))
            return new StartQuery();
        // GameStart
        else if (command.Contains("/gamestart"))
            return new GameStartQuery();
        // GameStop
        else if (command.Contains("/gamestop"))
            return new GameStopQuery();
        // Choice
        else if (command.Contains("/choice"))
            return new ChoiceQuery();
        // Mark
        else if (command.Contains("/mark"))
            return new MarkQuery();
        // Help
        else if (command.Contains("/help"))
            return new HelpQuery();

        return new HelpQuery();
    }
}
