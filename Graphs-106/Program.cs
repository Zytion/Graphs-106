using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_106
{
	class Program
	{
		static void Main(string[] args)
		{
			Graph house = new Graph();
			house.ListAllVertices();
			bool running = true;

			String currentRoom = "Living Room";
			
			while(running)
			{
				string input = "";
				Console.WriteLine("You are currently in the " + house.GetRoomString(currentRoom));
				Console.Write("Nearby are: ");
				foreach(Vertex room in house.GetAdjacentList(currentRoom))
					Console.Write(room.RoomName + " ");

				while(!house.IsConnected(currentRoom, input))
				{
					Console.Write("\nWhere would you like to go? ");
					input = Console.ReadLine();
					if(!house.IsConnected(currentRoom, input))
						Console.WriteLine("Sorry, that is not an adjacent room.");
				}
				currentRoom = input;

				if(currentRoom.Equals("Exit"))
				{
					running = false;
					Console.WriteLine("You have left the house.");
				}
			}

			Console.ReadLine();
		}
	}
}
