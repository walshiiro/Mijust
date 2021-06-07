using System.IO;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Mijustbotx
{
    public class Bot
    {
        public  DiscordClient Client { get; private set; }
        public async Task runasync()
        {
            var json = string.Empty;
            using(var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);
            var configjson = JsonConvert.DeserializeObject<configjson>(json);
            var config = new DiscordConfiguration()
            {
                Token = configjson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = LogLevel.Debug,




            };
             Client = new DiscordClient(config);
             Client.Ready += OnClientReady;
             var commandsconfig = new CommandsNextConfiguration()
             {
                 StringPrefixes = new[] {configjson.Prefix},
                 EnableDms = false,
                 EnableMentionPrefix = true,
                 DmHelp = true,
                 
             };
             Commands = Client.UseCommandsNext(commandsconfig);
             Commands.RegisterCommands<listcommand>();
             await Client.ConnectAsync();
             
             
             await Task.Delay(-1);
        }

        public CommandsNextExtension Commands { get; private set; }


        private Task OnClientReady(object sender, ReadyEventArgs e)

        {
            return Task.CompletedTask;
        }
        
    }
}