using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TgBot_Reposter_TUE
{
    public class TelegramBot(string botToken, long sourceChannelId, List<long> destinationChannelIds, int syncInterval)
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task StartAsync()
        {
            while (true)
            {
                try
                {
                    List<Message> newMessages = await GetNewMessagesAsync();

                    foreach (var message in newMessages)
                    {
                        await ForwardMessageAsync(message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                await Task.Delay(syncInterval);
            }
        }

        private async Task<List<Message>> GetNewMessagesAsync()
        {
            // Тут должен быть код для получения новых сообщений из канала или пользователя
            // Пример получения последних N сообщений из канала
            var url = $"https://api.telegram.org/bot{botToken}/getUpdates"; // обновите под вашу логику получения сообщений
            var response = await _httpClient.GetStringAsync(url);

            var updates = JsonConvert.DeserializeObject<UpdatesResponse>(response);
            // Обработайте и выберите новые сообщения
            // Сохраните ID последних обработанных сообщений, чтобы не обрабатывать их снова

            // Верните список новых сообщений
            return new List<Message>(); // Вернутся новые сообщения
        }

        private async Task ForwardMessageAsync(Message message)
        {
            foreach (var destinationChannelId in destinationChannelIds)
            {
                var url = $"https://api.telegram.org/bot{botToken}/forwardMessage?chat_id={destinationChannelId}&from_chat_id={sourceChannelId}&message_id={message.MessageId}";
                await _httpClient.GetStringAsync(url);
            }
        }
    }

    // Классы для десериализации ответов от Telegram API
    public class UpdatesResponse
    {
        public List<Update>? Result { get; set; }
    }

    public class Update
    {
        public Message? Message { get; set; }
    }

    public class Message
    {
        public int MessageId { get; set; }
        public string? Text { get; set; }
        // Добавьте другие необходимые поля сообщений
    }
}