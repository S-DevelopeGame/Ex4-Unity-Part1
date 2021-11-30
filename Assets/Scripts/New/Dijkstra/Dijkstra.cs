using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dijkstra : MonoBehaviour
{
    public static Dictionary<NodeType, NodeType> FindPath<NodeType>(IWGraph<NodeType> graph, NodeType startNode)
    {
        Dictionary<NodeType, int> weights = new Dictionary<NodeType, int>(); // weights of the nodes
        Dictionary<NodeType, bool> hasVisited = new Dictionary<NodeType, bool>(); // check if this node had visited
        Dictionary<NodeType, NodeType> path = new Dictionary<NodeType, NodeType>(); // the ans path to the 

        Queue<NodeType> queue = new Queue<NodeType>(); //empty Queue

        queue.Enqueue(startNode); // add the start node to the queue
        weights.Add(startNode, 0); // add the weight of the start node
        while (queue.Count != 0) // while the queue is not empty
        {
            NodeType n = queue.Peek();
            if (!hasVisited.ContainsKey(n)) //if has not visted in the node
            {
                hasVisited.Add(n, true); // visited the current node
                queue.Dequeue(); 

                foreach (var neighbor in graph.Neighbors(n))
                {
                    if (weights.ContainsKey(neighbor))
                    {
                        if (weights[neighbor] > graph.getW(neighbor) + weights[n])
                        {
                            weights[neighbor] = graph.getW(neighbor) + weights[n];
                            path[neighbor] = n;

                        }
                    }
                    else
                    {
                        weights[neighbor] = graph.getW(neighbor) + weights[n];
                        path[neighbor] = n;
                    }
                    if (!hasVisited.ContainsKey(neighbor))
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }
            else
            {
                queue.Dequeue();
            }
        }
        return path;

    }

    public static List<NodeType> GetPath<NodeType>(IWGraph<NodeType> graph, NodeType startNode, NodeType endNode)
    {
        List<NodeType> ans_path = new List<NodeType>();
        Dictionary<NodeType, NodeType> path = FindPath<NodeType>(graph, startNode);
        if (path.ContainsKey(endNode))
        {
            NodeType td = endNode;
            ans_path.Insert(0, td); //

            while (!ans_path[0].Equals(startNode))
            {
                td = path[td];
                ans_path.Insert(0, td);
            }
        }
        return ans_path;
    }
}
