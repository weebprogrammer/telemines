namespace telemines;

using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

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

        if (message.Text.ToLower().Contains("/gamestart"))
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Игра началась!");
            return;
        }

    }

    async static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        
    }
}
