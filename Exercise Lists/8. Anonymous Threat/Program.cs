using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> data = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();
            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input
                 .Split(" ")
                 .ToArray();
                int startIndex, endIndex;
                if (command[0] == "merge")
                {
                    startIndex = int.Parse(command[1]);
                    endIndex = int.Parse(command[2]);
                    Merge(data, startIndex, endIndex);
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partition = int.Parse(command[2]);
                    Divide(data, index, partition);
                }
            }
            Console.WriteLine(String.Join(" ",data));

        }
        static void Merge(List<string> data, int startIndex, int endIndex)
        {
            StringBuilder newString = new StringBuilder();
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex < data.Count)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    newString.Append(data[startIndex]);
                    data.RemoveAt(0);
                    data.Insert(startIndex, newString.ToString());
                }
            }
            else if (endIndex >= data.Count)
            {
                for (int i = startIndex; i < data.Count; i++)
                {
                    newString.Append(data[startIndex]);
                    data.RemoveAt(0);
                    data.Insert(startIndex, newString.ToString());
                }
            }
        }
        static void Divide(List<string> data, int index, int partitions)
        {
            string word = data[index];
            if (partitions > word.Length)
            {
                return;
            }
            List<string> partitionsList = new List<string>();
            int partitionsLenght = word.Length / partitions;
            int partitionsRemain = word.Length % partitions;
            int lastPartitionLenght = partitionsLenght + partitionsRemain;
            for (int i = 0; i < partitions; i++)
            {
                char[] currentPartition;
                if (i == partitions - 1)
                {
                    currentPartition = word
                        .Skip(i * partitionsLenght)
                        .Take(lastPartitionLenght)
                        .ToArray();
                }
                else
                {
                    currentPartition = word
                        .Skip(i * partitions)
                        .Take(partitionsLenght)
                        .ToArray();
                }
                partitionsList.Add(new string(currentPartition));
                data.RemoveAt(index);
                data.InsertRange(index, partitionsList);
            }

        }
    }
}
