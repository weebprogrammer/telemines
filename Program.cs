namespace telemines;

using System;
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

        // Start
        if (message.Text.ToLower().Contains("/start"))
            await Task.Run(() => manager.Query(new StartQuery()));
        // GameStart
        else if (message.Text.ToLower().Contains("/gamestart"))
            await Task.Run(() => manager.Query(new GameStartQuery()));
        // GameStop
        else if (message.Text.ToLower().Contains("/gamestop"))
            await Task.Run(() => manager.Query(new GameStopQuery()));
        // Choice
        else if (message.Text.ToLower().Contains("/choice"))
            await Task.Run(() => manager.Query(new ChoiceQuery()));
        // Mark
        else if (message.Text.ToLower().Contains("/mark"))
            await Task.Run(() => manager.Query(new MarkQuery()));
        // Help
        else if (message.Text.ToLower().Contains("/help"))
            await Task.Run(() => manager.Query(new HelpQuery()));
    }

    async static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        
    }
}
