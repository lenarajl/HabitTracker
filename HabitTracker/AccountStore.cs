using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HabitTracker
{
    public static class AccountStore
    {
        private static List<Account> accounts = new List<Account>();

        public static Account CreateAccount(string userName)
        {
            var account = new Account()
            {
                UserName = userName,
                Habits = new List<Habit>()
            };
            accounts.Add(account);
            return account;
        }

        public static Account GetAccount(string userName)
        {
            return accounts.Where(acc => acc.UserName == userName).FirstOrDefault();
        }

        public static void AddHabit(string userName, Habit habit)
        {
            var account = GetAccount(userName);
            account.Habits.Add(habit);
        }

        public static void TrackHabit(string userName, string habitNAme)
        {
            var account = GetAccount(userName);
            var habit = account.Habits.Where(hab => hab.Name == habitNAme).FirstOrDefault();
            habit.WeeklyCompletion++;
        }

        public static List<Habit> GetHabits(string userName)
        {
            var account = GetAccount(userName);
            return account.Habits;
        }
    }
}
