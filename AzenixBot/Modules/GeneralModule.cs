namespace AzenixBot.Modules
{
    using Discord;
    using Discord.Commands;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class GeneralModule : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task Help()
        {
            EmbedBuilder builder = new EmbedBuilder();
            
            builder.WithTitle("Azenix Bot Help")
                .WithColor(AzenixBot.Common.DiscordExtensions.WhiteColor);
            builder.AddField("//help", "shows available commands");
            builder.AddField("//azenix or //xaz", "shows coin info");
            builder.AddField("//balance [public address]", "shows the balance of inputted address");
            builder.AddField("//tip [@member]", "tips a member of this discord channel");
            builder.AddField("//nextmn ", "calculates when a user has enough coins for next masternode");

            await this.ReplyAsync(string.Empty, false, builder.Build());
        }
    }
}
