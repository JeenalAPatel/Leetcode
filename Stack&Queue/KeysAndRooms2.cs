using System.Collections.Generic;

namespace LeetCode
{
    public class KeysAndRooms2
    {
        private bool[] Visited;

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            Visited = new bool[rooms.Count];
            Visited[0] = true;
            var stack = new Stack<int>();
            stack.Push(0);
            while (stack.Count != 0)
            {
                int node = stack.Pop();
                foreach (var item in rooms[node])
                {
                    if (!Visited[item])
                    {
                        Visited[item] = true;
                        stack.Push(item);
                    }
                }
            }

            foreach (var item in Visited)
            {
                if (!item)
                    return false;
                
            }
            return true;
        }
    }
}