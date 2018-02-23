namespace AzenixBot.Modules
{
    using Discord;
    using Discord.Commands;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.Net.Http;

    public class NodeModule : ModuleBase<SocketCommandContext>
    {
        private static HttpClient client = new HttpClient();

        [Command("balance")]
        public async Task Balance(string address)
        {
            var result = await this.GetAddressBalance(address);

            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Azenix Bot Balance");
            builder.WithDescription(result.ToString() + " satoshi");

            await this.Context.Message.Author.SendMessageAsync(string.Empty, false, builder.Build());
        }

        private async Task<string> GetAddressBalance(string address)
        {
            HttpResponseMessage response = await client.GetAsync($"https://blockchain.info/q/addressbalance/{address}");
            var result = response.Content.ReadAsStringAsync();

            return result.Result;
        }
    }
}
