using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_106
{
	/// <summary>
	/// Holds the room information
	/// </summary>
	class Vertex
	{
		private string roomName;
		private string roomDesc;

		/// <summary>
		/// Name of the room you are in
		/// </summary>
		public string RoomName { get { return roomName; } set { roomName = value; } }

		/// <summary>
		/// Description of what is in the room
		/// </summary>
		public string RoomDesc { get { return roomDesc; } set { roomDesc = value; } }

		/// <summary>
		/// Creates a room with a name and description
		/// </summary>
		/// <param name="name"></param>
		/// <param name="description"></param>
		public Vertex(string name, string description)
		{
			roomName = name;
			roomDesc = description;
		}
		/// <summary>
		/// Returns the room name and description
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return roomName + ": " + roomDesc;
		}
	}
}
