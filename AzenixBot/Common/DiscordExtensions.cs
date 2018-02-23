using System.Threading.Tasks;
using Discord.WebSocket;

namespace AzenixBot.Common
{
    public static class DiscordExtensions
    {
        public static Discord.Color WhiteColor { get => new Discord.Color(255, 255, 255); }

        public static async Task SetGameAsPrice(this DiscordSocketClient client)
        {
            await client.SetGameAsync("//help");
        }
    }
}

