# 🏋️‍♂️ Fitness Tracking App

## 📖 Project Overview
The **Fitness Tracking App** is an object-oriented program designed to log, update, review, adjust, and track workout sessions. It also generates progress reports based on user activities. The app follows a **state machine model** to transition workouts through various stages.

## 🛠️ Features
- **Workout Management**: Log, update, review, adjust, archive, and track workouts.
- **State Machine Implementation**: Ensures workouts follow a proper sequence of states.
- **Progress Report Generation**: Displays workout summaries.
- **Unit Testing**: Ensures the accuracy of the system's functionality.

## 📝 Class Descriptions

### 📌 `Workout` Class
The **Workout** class handles user workouts and tracks their progress through various states.

#### 🔹 Attributes:
- `WorkoutType`: Type of exercise.
- `Duration`: Length of the workout in minutes.
- `Date`: Date of the workout.
- `State`: Current state of the workout.

#### 🔹 Methods:
- `LogWorkout()`
- `UpdateWorkout()`
- `ReviewWorkout()`
- `AdjustWorkout()`
- `ArchiveWorkout()`
- `TrackWorkout()`

### 📌 `ProgressReport` Class
Handles the generation of progress reports.

#### 🔹 Attributes:
- `Report`: Stores the progress report message.

#### 🔹 Methods:
- `GenerateReport()`: Displays the progress report.

## 🧪 Unit Tests
Unit tests are included to verify correct implementation.

✅ **Workout Tests**:
- Workout initialization
- State transitions (Logged, Updated, Reviewed, Managed, Archived, Tracked)

✅ **Progress Report Tests**:
- Report generation with valid data
- Handling empty or null reports
