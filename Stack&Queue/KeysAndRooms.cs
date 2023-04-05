using System.Collections.Generic;

namespace LeetCode
{
    public class KeysAndRooms
    {
        private bool[] visited;
        public bool CanVisitAllRooms(List<List<int>> rooms)
        {
            visited = new bool[rooms.Count];
            VisitedRoom(rooms, 0);
            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i])
                {
                    return false;
                }
            }

            return true;
        }

        public void VisitedRoom(List<List<int>> rooms, int node)
        {
            visited[node] = true;
            foreach (var item in rooms[node])
            {
                
                    if (!visited[item])
                    {
                        VisitedRoom(rooms,item);
                    }
                
            }
        }
    }
}