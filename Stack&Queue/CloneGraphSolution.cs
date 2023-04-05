using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Node
    {
        public int val;
        public Node? next;
        public Node? random;
        public List<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int val)
        {
            this.val = val;
            neighbors = new List<Node>();
        }

        public Node(int val, List<Node> neighbors)
        {
            this.val = val;
            this.neighbors = neighbors;
        }
    }

    public class CloneGraphSolution
    {
        public Node rootNode;

        public CloneGraphSolution(int[][] arr)
        {
            var nodeDictionary = new Dictionary<int, Node>();
            foreach (var row in arr)
            {
                var element1 = row[0];
                var element2 = row[1];
                if (!nodeDictionary.TryGetValue(element1, out var node1))
                {
                    node1 = new Node(element1);
                    nodeDictionary.Add(element1, node1);
                }

                if (!nodeDictionary.TryGetValue(element2, out var node2))
                {
                    node2 = new Node(element2);
                    nodeDictionary.Add(element2, node2);
                }

                node1.neighbors.Add(node2);
                node2.neighbors.Add(node1);
            }

            rootNode = nodeDictionary.FirstOrDefault().Value;
        }

        public Node? CloneGraph(Node? node)
        {
            if (node == null) return null;
            var cache = new Dictionary<Node, Node>();
            var clone = new Node(node.val);
            cache[node] = clone;

            var queue = new Queue<(Node, Node)>();
            queue.Enqueue((node, clone));

            while (queue.Count > 0)
            {
                var (currNode, currNodeClone) = queue.Dequeue();

                foreach (var neighbor in currNode.neighbors)
                {
                    if (cache.TryGetValue(neighbor, out var neighborClone))
                    {
                        currNodeClone.neighbors.Add(neighborClone);
                    }
                    else
                    {
                        var newNeighborClone = new Node(neighbor.val);
                        currNodeClone.neighbors.Add(newNeighborClone);
                        cache[neighbor] = newNeighborClone;
                        queue.Enqueue((neighbor, newNeighborClone));
                    }
                }
            }

            return clone;
        }
    }
}