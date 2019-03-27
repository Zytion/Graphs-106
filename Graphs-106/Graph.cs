using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_106
{
	/// <summary>
	/// A Graph used to create a house layout
	/// </summary>
	class Graph
	{
		/// <summary>
		/// A list of all the rooms (by name) and the rooms that are adjacent to them
		/// </summary>
		private Dictionary<string, List<Vertex>> adjacencyList;
		private List<Vertex> rooms;

		/// <summary>
		/// Get a list of the rooms in the house
		/// </summary>
		public List<Vertex> Rooms { get { return rooms; } }

		public Graph()
		{
			adjacencyList = new Dictionary<string, List<Vertex>>();
			rooms = new List<Vertex>();
			//Add rooms to the list
			rooms.Add(new Vertex("Living Room", "A comfy room with a couch, tv, and bookselves."));
			rooms.Add(new Vertex("Bedroom", "A place to sleep. Has a bed and a desk to work at."));
			rooms.Add(new Vertex("Bathroom", "Contains a toilet, shower, and sink. "));
			rooms.Add(new Vertex("Kitchen", "Has everything you need to make your meals."));
			rooms.Add(new Vertex("Exit", "Exit to the house."));

			//Living room connections
			adjacencyList.Add("Living Room", new List<Vertex>());
			adjacencyList["Living Room"].AddRange(rooms.GetRange(1,3));
			//Bedroom connections
			adjacencyList.Add("Bedroom", new List<Vertex>());
			adjacencyList["Bedroom"].Add(rooms[0]);
			adjacencyList["Bedroom"].Add(rooms[3]);
			//Bathroom connections
			adjacencyList.Add("Bathroom", new List<Vertex>());
			adjacencyList["Bathroom"].Add(rooms[0]);
			//Kitchen connections
			adjacencyList.Add("Kitchen", new List<Vertex>());
			adjacencyList["Kitchen"].Add(rooms[0]);
			adjacencyList["Kitchen"].Add(rooms[1]);
			adjacencyList["Kitchen"].Add(rooms[4]);
			//Exit connections
			adjacencyList.Add("Exit", new List<Vertex>());
			adjacencyList["Exit"].Add(rooms[3]);

		}
		/// <summary>
		/// Accepts the name of a room and returns a list of adjacent rooms
		/// If the specified room is not in the dictionary, simply return null
		/// </summary>
		/// <param name="room"></param>
		/// <returns></returns>
		public List<Vertex> GetAdjacentList(string room)
		{
			return adjacencyList[room];
		}
		/// <summary>
		/// Determines if room2 is directly connected to room1
		/// </summary>
		/// <param name="room1"></param>
		/// <param name="room2"></param>
		/// <returns></returns>
		public bool IsConnected(string room1, string room2)
		{
			foreach(Vertex room in adjacencyList[room1])
			{
				if (room.RoomName.Equals(room2))
					return true;
			}
			return false;
		}
		/// <summary>
		/// Iterate through all of the rooms and print the room name and description. 
		/// </summary>
		public void ListAllVertices()
		{
			foreach (Vertex room in rooms)
				Console.WriteLine(room.ToString());
			Console.WriteLine();
		}
		/// <summary>
		/// Returns a string containing the given room's name and description
		/// </summary>
		/// <param name="roomName"></param>
		/// <returns></returns>
		public string GetRoomString(string roomName)
		{
			foreach(Vertex room in rooms)
			{
				if(room.RoomName.Equals(roomName))
					return room.ToString();
			}
			return "";
		}
	}
}
