using DSharpPlus.CommandsNext;
using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext.Attributes;

namespace Mijustbotx
{
    public class listcommand : BaseCommandModule
    {
        [Command("Ping")]
        public async Task Ping(CommandContext ctx)
        {
           await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("Dave")]
        public async Task Dave(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Ngu").ConfigureAwait(false);
        }
    }
}