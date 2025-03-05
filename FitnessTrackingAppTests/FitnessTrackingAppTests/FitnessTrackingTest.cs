using FitnessTrackingApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessTrackingAppTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Test_WorkoutInitialization()
        {
            // Arrange
            Workout workout = new Workout("Running", 30, "2024-06-16");

            // Act & Assert
            Assert.AreEqual("Initialized", workout.State);
            Assert.AreEqual("Running", workout.WorkoutType);
            Assert.AreEqual(30, workout.Duration);
            Assert.AreEqual("2024-06-16", workout.Date);
        }

        [TestMethod]
        public void Test_WorkoutLogged()
        {
            // Arrange
            Workout workout = new Workout("Cycling", 45, "2024-06-16");

            // Act
            workout.LogWorkout();

            // Assert
            Assert.AreEqual("Workout Logged", workout.State);
        }

        [TestMethod]
        public void Test_WorkoutUpdated()
        {
            // Arrange
            Workout workout = new Workout("Cycling", 45, "2024-06-16");
            workout.LogWorkout();

            // Act
            workout.UpdateWorkout();

            // Assert
            Assert.AreEqual("Updated", workout.State);
        }

        [TestMethod]
        public void Test_WorkoutReviewed()
        {
            // Arrange
            Workout workout = new Workout("Cycling", 45, "2024-06-16");
            workout.LogWorkout();
            workout.UpdateWorkout();

            // Act
            workout.ReviewWorkout();

            // Assert
            Assert.AreEqual("Reviewed", workout.State);
        }

        [TestMethod]
        public void Test_WorkoutManaged()
        {
            // Arrange
            Workout workout = new Workout("Cycling", 45, "2024-06-16");
            workout.LogWorkout();
            workout.UpdateWorkout();
            workout.ReviewWorkout();

            // Act
            workout.AdjustWorkout();

            // Assert
            Assert.AreEqual("Managed", workout.State);
        }

        [TestMethod]
        public void Test_WorkoutArchived()
        {
            // Arrange
            Workout workout = new Workout("Cycling", 45, "2024-06-16");
            workout.LogWorkout();
            workout.UpdateWorkout();
            workout.ReviewWorkout();
            workout.AdjustWorkout();

            // Act
            workout.ArchiveWorkout();

            // Assert
            Assert.AreEqual("Archived", workout.State);
        }

        [TestMethod]
        public void Test_WorkoutTracked()
        {
            // Arrange
            Workout workout = new Workout("Cycling", 45, "2024-06-16");
            workout.LogWorkout();
            workout.UpdateWorkout();
            workout.ReviewWorkout();
            workout.AdjustWorkout();
            workout.ArchiveWorkout();

            // Act
            workout.TrackWorkout();

            // Assert
            Assert.AreEqual("Tracked", workout.State);
        }
        // Test for valid ProgressReport generation
        [TestMethod]
        public void Test_GenerateProgressReport()
        {
            // Arrange
            ProgressReport progressReport = new ProgressReport("User completed 30 minutes of cycling.");

            // Act
            string actual = progressReport.Report;
            Console.WriteLine($"Actual Output: '{actual}'"); // Debug output

            // Assert
            Assert.AreEqual("Progress Report: User completed 30 minutes of cycling.", actual);
        }

        // Test for ProgressReport with an empty message
        [TestMethod]
        public void Test_EmptyProgressReport()
        {
            // Arrange
            ProgressReport progressReport = new ProgressReport(""); // Empty input

            // Act
            string actual = progressReport.Report;
            Console.WriteLine($"Actual Output: '{actual}'"); // Debug output

            // Assert
            Assert.AreEqual("Progress Report: No data available.", actual);
        }

        // Test for ProgressReport with a null message
        [TestMethod]
        public void Test_NullProgressReport()
        {
            // Arrange
            ProgressReport progressReport = new ProgressReport(null); // Null input

            // Act
            string actual = progressReport.Report;
            Console.WriteLine($"Actual Output: '{actual}'"); // Debug output

            // Assert
            Assert.AreEqual("Progress Report: No data available.", actual);
        }
    }
}