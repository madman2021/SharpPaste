using System;

namespace SharpPasteCli
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			switch (args[0])
			{
				case "help":
					Console.WriteLine("This is the help!");
					break;
				case "list":
					switch (args[1])
					{
						case "pastes":
							Lister.ListPastes();
							break;
						default:
							break;
					}
					break;
				default:
					Console.WriteLine("Invalid parameter!");
					break;
			}
		}
	}
}