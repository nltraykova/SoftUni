using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfPhones = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split().ToArray();

                string cmd = tokens[0];

                switch (cmd)
                {
                    case"Add":
                        if (!listOfPhones.Contains(tokens[2]))
                        {
                            listOfPhones.Add(tokens[2]);
                        }
                        break;
                    case "Remove":
                        if (listOfPhones.Contains(tokens[2]))
                        {
                            listOfPhones.RemoveAll(phone => phone == tokens[2]);
                        }
                            break;
                    case "Bonus":
                        string[] oldAndNewPhone = tokens[3].Split(':').ToArray();
                        string oldPhone = oldAndNewPhone[0];
                        string newPhone = oldAndNewPhone[1];

                        if (listOfPhones.Contains(oldPhone))
                        {
                            int indexOfOldPhone = listOfPhones.IndexOf(oldPhone);
                            listOfPhones.Insert(indexOfOldPhone + 1, newPhone);
                        }
                        break;
                    case "Last":
                        if (listOfPhones.Contains(tokens[2]))
                        {
                            string phone = tokens[2];
                            listOfPhones.Add(phone);
                            int indexOfPhone = listOfPhones.IndexOf(phone);
                            listOfPhones.RemoveAt(indexOfPhone);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", listOfPhones));
        }
    }
}
