namespace AzenixBot.Modules
{
    using Discord;
    using Discord.Commands;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class CoinInfoModule : ModuleBase<SocketCommandContext>
    {
        [Command("azenix")][Alias("xaz")]
        public async Task Azenix()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Azenix [XAZ]")
                .WithDescription("Zero Fee Currency")
                .WithFooter("https://www.azenix.io")
                .WithThumbnailUrl("http://i67.tinypic.com/15n0h7o.png")
                .WithColor(AzenixBot.Common.DiscordExtensions.WhiteColor);

            builder.AddField("Specifications:", "\u200b");
            builder.AddInlineField("Algorhitm", "x11");
            builder.AddInlineField("Coin supply", "21000k");

            await this.ReplyAsync(string.Empty, false, builder.Build());
        }
    }
}
