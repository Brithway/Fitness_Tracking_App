using FitnessTrackingApp;
using System;

namespace FitnessTrackingApp
{
    public class Workout
    {
        // Properties for Workout
        public string WorkoutType { get; private set; }
        public int Duration { get; private set; }
        public string Date { get; private set; }
        public string State { get; private set; }

        // Default constructor
        public Workout()
        {
            State = "Initialized";
        }

        // Parameterized constructor
        public Workout(string workoutType, int duration, string date)
        {
            WorkoutType = workoutType;
            Duration = duration;
            Date = date;
            State = "Initialized";
        }

        // Method to Log a workout (change state to 'Workout Logged')
        public void LogWorkout()
        {
            if (State == "Initialized")
                State = "Workout Logged";
        }

        // Method to update the workout (change state to 'Updated')
        public void UpdateWorkout()
        {
            if (State == "Workout Logged")
                State = "Updated";
        }

        // Method to review the workout (change state to 'Reviewed')
        public void ReviewWorkout()
        {
            if (State == "Updated")
                State = "Reviewed";
        }

        // Method to adjust the workout (change state to 'Managed')
        public void AdjustWorkout()
        {
            if (State == "Reviewed")
                State = "Managed";
        }

        // Method to archive the workout (change state to 'Archived')
        public void ArchiveWorkout()
        {
            if (State == "Managed")
                State = "Archived";
        }

        // Method to track the workout (change state to 'Tracked')
        public void TrackWorkout()
        {
            if (State == "Archived")
                State = "Tracked";
        }
    }

    // Progress Report class to simulate logging of progress
    public class ProgressReport
    {
        public string Report { get; private set; }

        public ProgressReport(string report)
        {
            // If the report is null or empty, set a default message
            if (string.IsNullOrWhiteSpace(report))
            {
                Report = "Progress Report: No data available.";  // Default message for null or empty input
            }
            else
            {
                Report = $"Progress Report: {report}";  // Regular formatted message
            }
        }

        // Method to generate and display the report
        public void GenerateReport()
        {
            Console.WriteLine(Report);  // Output the report
        }
    }

    // Main class to run the application
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example: Running workout and tracking state changes
            Workout workout = new Workout("Cycling", 30, "2024-12-16");
            Console.WriteLine($"Initial State: {workout.State}");

            workout.LogWorkout();
            Console.WriteLine($"State after logging workout: {workout.State}");

            workout.UpdateWorkout();
            Console.WriteLine($"State after updating workout: {workout.State}");

            workout.ReviewWorkout();
            Console.WriteLine($"State after reviewing workout: {workout.State}");

            workout.AdjustWorkout();
            Console.WriteLine($"State after adjusting workout: {workout.State}");

            workout.ArchiveWorkout();
            Console.WriteLine($"State after archiving workout: {workout.State}");

            workout.TrackWorkout();
            Console.WriteLine($"State after tracking workout: {workout.State}");

            // Generating Progress Report with valid message
            Console.WriteLine("\nGenerating Progress Report:");
            ProgressReport progressReport = new ProgressReport("User completed 30 minutes of cycling.");
            progressReport.GenerateReport();  // Output the report

            // Generating Progress Report with empty message
            Console.WriteLine("\nGenerating Empty Progress Report:");
            ProgressReport emptyProgressReport = new ProgressReport("");
            emptyProgressReport.GenerateReport();  // Output the report with empty message

            // Generating Progress Report with null message
            Console.WriteLine("\nGenerating Null Progress Report:");
            ProgressReport nullProgressReport = new ProgressReport(null);
            nullProgressReport.GenerateReport();  // Output the report with null message

            Console.ReadLine(); // Keep the console open
        }
    }
}