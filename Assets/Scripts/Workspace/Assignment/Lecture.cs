using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
             LCT01_SyntaxList();
             LCT02_SyntaxLinkedList();
             LCT03_SyntaxHashTable();
             LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");

            foreach (string fruit in fruits)
            {
                Debug.Log(fruit);
            }

            Debug.Log($"First fruit: {fruits[0]}");

            fruits.Remove("Banana");

            Debug.Log("After Remove:");

            foreach (string fruit in fruits)
            {
                Debug.Log(fruit);
            }
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> nodes =
                new LinkedList<string>();

            nodes.AddLast("Node 1");
            nodes.AddLast("Node 2");

            nodes.AddFirst("Node 0");

            Debug.Log("Initial LinkedList:");

            foreach (string node in nodes)
            {
                Debug.Log(node);
            }

            Debug.Log($"First: {nodes.First.Value}");
            Debug.Log($"Last: {nodes.Last.Value}");

            Debug.Log(
                $"First Previous is null: {nodes.First.Previous == null}"
            );

            Debug.Log(
                $"Last Next is null: {nodes.Last.Next == null}"
            );

            LinkedListNode<string> target =
                nodes.Find("Node 1");

            nodes.AddBefore(target, "Before Node 1");
            nodes.AddAfter(target, "After Node 1");

            Debug.Log("After AddBefore / AddAfter:");

            foreach (string node in nodes)
            {
                Debug.Log(node);
            }

            nodes.RemoveFirst();
            nodes.Remove("Node 2");

            Debug.Log("Final LinkedList:");

            foreach (string node in nodes)
            {
                Debug.Log(node);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            Hashtable fruits = new Hashtable();

            fruits.Add(1, "Apple");
            fruits.Add(2, "Banana");
            fruits.Add("bad-fruit", "Rotten Tomato");

            string fruit1 = (string)fruits[1];
            string fruit2 = (string)fruits[2];
            string badFruit = (string)fruits["bad-fruit"];

            Debug.Log($"fruit1: {fruit1}");
            Debug.Log($"fruit2: {fruit2}");
            Debug.Log($"badFruit: {badFruit}");

            Debug.Log("All Hashtable entries:");

            foreach (DictionaryEntry entry in fruits)
            {
                Debug.Log(
                    $"key: {entry.Key}, value: {entry.Value}"
                );
            }

            if (fruits.ContainsKey(2))
            {
                Debug.Log("found 2");
            }

            fruits.Remove(1);

            Debug.Log("After Remove key 1:");

            foreach (DictionaryEntry entry in fruits)
            {
                Debug.Log(
                    $"key: {entry.Key}, value: {entry.Value}"
                );
            }
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int, string> fruits =
                new Dictionary<int, string>();

            fruits.Add(1, "Apple");
            fruits.Add(2, "Banana");

            fruits[3] = "Cherry";

            foreach (KeyValuePair<int, string> pair in fruits)
            {
                Debug.Log(
                    $"key: {pair.Key}, value: {pair.Value}"
                );
            }

            if (fruits.ContainsKey(1))
            {
                Debug.Log(
                    $"value of key 1 : {fruits[1]}"
                );
            }

            Debug.Log("All keys in dictionary:");

            foreach (int key in fruits.Keys)
            {
                Debug.Log(key);
            }

            fruits.Remove(3);

            Debug.Log(
                $"Dictionary has {fruits.Count} keys"
            );

            fruits.Clear();
        }

        #endregion
    }
}

