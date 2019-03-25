using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_106
{
	class Vertex
	{
		private string roomName;
		private string roomDesc;

		public string RoomName { get { return roomName; } set { roomName = value; } }

		public string RoomDesc { get { return roomDesc; } set { roomDesc = value; } }

		public Vertex(string name, string description)
		{
			roomName = name;
			roomDesc = description;
		}
		public override string ToString()
		{
			return roomName + ": " + roomDesc;
		}
	}
}
