namespace AzenixBot.Modules
{
    using Discord;
    using Discord.Commands;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class MasternodeModule : ModuleBase<SocketCommandContext>
    {
        [Command("nextmn")]
        public async Task Help()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Azenix Bot Help");
            builder.AddField("//help", "shows available commands");
            builder.AddField("//azenix or //xaz", "shows coin info");
            builder.AddField("//balance [public address]", "shows coin info");
            builder.AddField("//tip [@member]", "tips a member of this discord channel");
            builder.AddField("//nextmn ", "tips a member of this discord channel");

            await this.ReplyAsync(string.Empty, false, builder.Build());
        }
    }
}
