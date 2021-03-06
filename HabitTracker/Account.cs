﻿using System;
using System.Collections.Generic;

namespace HabitTracker
{
    /// <summary>
    /// The Account represents a user's account
    /// with their input habits and respective
    /// goals to help track progress.
    /// </summary>
    public class Account
    {
        #region Properties

        public Account()
        {
        }

        /// <summary>
        /// User name is the chosen user name
        /// by the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Habits stored in an account.
        /// </summary>
        public List<Habit> Habits { get; set; }
      
        #endregion

    }

}

