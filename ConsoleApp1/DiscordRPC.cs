using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace ConsoleApp1
{
	class DiscordRPC
	{
		public static DiscordRpcClient client;

		public static void Initialize()
		{
			
            client = new DiscordRpcClient("1001074622030151680");
            client.Initialize();
            client.SetPresence(new RichPresence()
			{
				Details = "CRACKTURKEY Spotify Checker",
				State = "Spotfiy Checking",
				Assets = new Assets()
				{
					LargeImageKey = "indir_1_",
					LargeImageText = ""
				}
			});
			

		}
	}
}
