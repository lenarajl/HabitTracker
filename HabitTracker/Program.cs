using System;
using System.Linq;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
            //Main is an entry point, everybody has Main and don't delete
        {
            Console.WriteLine("***Welcome to your HabitTracker!***");

            while(true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Create a habit");
                Console.WriteLine("3. Track a habit");
                Console.WriteLine("4. Print all habits");

                var option = Console.ReadLine();
                string userName;
                string habitName;
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting your Habit Tracker!");
                        return;
                    case "1":
                        Console.WriteLine("Username: ");
                        userName = Console.ReadLine();
                        AccountStore.CreateAccount(userName);
                        break;
                    case "2":
                        Console.WriteLine("Username: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("Habit Name: ");
                        habitName = Console.ReadLine();
                        Console.WriteLine("Habit Weekly Goal: ");
                        var weeklyGoalString = Console.ReadLine();
                        var weeklyGoal = int.Parse(weeklyGoalString);
                        var habit = new Habit
                        {
                            Name = habitName,
                            WeeklyGoal = weeklyGoal
                        };
                        AccountStore.AddHabit(userName, habit);
                        break;
                    case "3":
                        Console.WriteLine("Username: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("Habit Name: ");
                        habitName = Console.ReadLine();
                        AccountStore.TrackHabit(userName, habitName);
                        break;
                    case "4":
                        Console.WriteLine("Username: ");
                        userName = Console.ReadLine();
                        var habits = AccountStore.GetHabits(userName);
                        habits.ForEach(hab =>
                        {
                            Console.WriteLine(hab.ToString());
                        });
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }


            }
       
        }
    }
}
