using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int msgCapacity = int.Parse(Console.ReadLine());
            List<User> usersList = new List<User>();
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string userName;
                int msgSent;
                int msgReceived;
                string[] cmdArgs = input
                .Split("=")
                .ToArray();
                if (cmdArgs[0] == "Add")
                {
                    userName = cmdArgs[1];
                    if (IsUserExist(usersList, userName))
                    {
                        continue;
                    }
                    msgSent = int.Parse(cmdArgs[2]);
                    msgReceived = int.Parse(cmdArgs[3]);
                    User newUser = new User(userName, msgSent, msgReceived);
                    usersList.Add(newUser);
                }
                else if (cmdArgs[0] == "Message")
                {
                    string sender = cmdArgs[1];
                    string receiver = cmdArgs[2];
                    if (IsUserExist(usersList, sender) && IsUserExist(usersList, receiver))
                    {
                        SendingMsg(usersList, sender, msgCapacity);
                        ReceivingMsg(usersList, receiver, msgCapacity);
                    }
                }
                else if (cmdArgs[0] == "Empty")
                {
                    userName = cmdArgs[1];
                    if (userName == "All")
                    {
                        usersList.Clear();
                        continue;
                    }
                    usersList.RemoveAll(x => x.Name == userName);
                }
            }
            Console.WriteLine($"Users count: {usersList.Count}");
            Console.WriteLine(String.Join(Environment.NewLine, usersList));
        }
        static bool IsUserExist(List<User> userList, string UserName)
        {
            foreach (var item in userList)
            {
                if (item.Name == UserName)
                {
                    return true;
                }
            }
            return false;
        }
        static void SendingMsg(List<User> userList, string userName, int msgCapacity)
        {
            foreach (var item in userList)
            {
                if (item.Name == userName)
                {
                    item.Sent += 1;
                    if (item.Sent + item.Received >= msgCapacity)
                    {
                        Console.WriteLine($"{userName} reached the capacity!");
                        userList.RemoveAll(x => x.Name == userName);
                        return;
                    }
                }
            }
        }
        static void ReceivingMsg(List<User> userList, string userName, int msgCapacity)
        {
            foreach (var item in userList)
            {
                if (item.Name == userName)
                {
                    item.Received += 1;
                    if (item.Received + item.Sent >= msgCapacity)
                    {
                        Console.WriteLine($"{userName} reached the capacity!");
                        userList.RemoveAll(x => x.Name == userName);
                        return;
                    }
                }
            }
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }

        public User(string userName, int msgSent, int msgReceived)
        {
            Name = userName;
            Sent = msgSent;
            Received = msgReceived;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Sent + this.Received}";
        }
    }
}
