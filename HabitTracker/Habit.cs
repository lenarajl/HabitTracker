using System;
namespace HabitTracker
{
    /// <summary>
    /// Habit class contains groups of habits that
    /// the user creates.
    /// Users use this class to view their progress
    /// towards habit goals by tracking their completion.
    /// </summary>
    public class Habit
    {
        #region Properties

        /// <summary>
        /// Group is the umbrella for a certain habit type.
        /// For example, a water intake habit would go under
        /// "health" Group. 
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Name indicates the name of the habit.
        /// For example a water intake habit's name would
        /// be Water Intake.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Weekly goal is input from the user on how many
        /// times they want to accomplish this goal per week.
        /// This data is used to calculate weekly success rate.
        /// </summary>
        public int WeeklyGoal { get; set; }

        /// <summary>
        /// Weekly completion is the amount of times the
        /// user completed the goal.
        /// For example, if a user drank water 15 times,
        /// then the weekly completion would be 15.
        /// </summary>
        public int WeeklyCompletion { get; set; }

        /// <summary>
        /// Weekly success is the percentage of the weekly
        /// goal that is met.
        /// It is calculated by dividing weekly completion
        /// by weekly goal.
        /// For example, if the weekly completion was 15 and
        /// the weekly goal was 30, the weekly success would
        /// 50%.
        /// </summary>
        public decimal WeeklySuccess { get; set; }

        #endregion

        public Habit()
        {
        }

    }
   
}