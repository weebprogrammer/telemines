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
        TelegramBotClient client = new TelegramBotClient("token");
        client.StartReceiving(Update, Error);
        Console.ReadLine();
    }

    async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
    {
        Message? message = update.Message;

        if (message.Text == null)
            return;

        Console.WriteLine(message.Chat.FirstName + "\t || \t" + message.Text);

        if (message.Text.ToLower().Contains("/start"))
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Для ознакомления напишите /help");
            return;
        }
        else if (message.Text.ToLower().Contains("/gamestart"))
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Игра началась!");
            return;
        }
        else if (message.Text.ToLower().Contains("/gamestop"))
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Игра закончилась!");
            return;
        }
        else if (message.Text.ToLower().Contains("/choice"))
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Выбрана клетка ...");
            return;
        }
        else if (message.Text.ToLower().Contains("/mark"))
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Выбрана марка ...");
            return;
        }
        else if (message.Text.ToLower().Contains("/help"))
        {
            string helpMessage = "";

            helpMessage += "/gamestart - начать игру\n";
            helpMessage += "/gamestop - завершить игру\n";
            helpMessage += "/choice column <value> - выборать столбец\n";
            helpMessage += "/choice row <value> - выборать строку\n";
            helpMessage += "/mark column <value> - выборать столбец\n";
            helpMessage += "/mark row <value> - выборать строку\n";

            await client.SendTextMessageAsync(message.Chat.Id, helpMessage);
            return;
        }

    }

    async static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        
    }
}
