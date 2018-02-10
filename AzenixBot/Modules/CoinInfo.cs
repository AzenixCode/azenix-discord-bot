using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AzenixBot.Modules
{
    public class CoinInfo : ModuleBase<SocketCommandContext>
    {
        [Command("info")]
        public async Task CoinInfoAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Azenix [XAZ]").WithDescription("Zero Fee Currency");

            await this.ReplyAsync(string.Empty, false, builder.Build());
        }
    }
}
