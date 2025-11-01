# ToDoTracker

A Windows Forms application for managing tasks and to-do items with persistent storage.

## Features

- Add new tasks with detailed properties
- Modify existing tasks
- Delete tasks
- Automatic data persistence using XML serialization
- Property-based task editing
- Task priority management
- Task state tracking

## Task Properties

Each task includes:
- Title - The main task description
- Description - Detailed information about the task
- Priority - High, Medium, or Low
- Start Date - When the task should begin
- End Date - When the task should be completed
- State - Created, Pending, or Completed

## How to Use

1. **Add a New Task**
   - Click the "Add" button
   - Fill in the task properties in the Property Editor
   - Click OK to save the new task

2. **Modify a Task**
   - Select a task from the grid
   - Click the "Modify" button
   - Update the properties as needed
   - Click OK to save changes

3. **Delete a Task**
   - Select a task from the grid
   - Click the "Delete" button
   - Confirm the deletion

## Data Storage

Tasks are automatically saved to:
`%AppData%\ToDoTracker\tasks.xml`

The application automatically loads your tasks when started and saves changes as you make them.

## System Requirements

- Windows Operating System
- .NET Framework 4.7.2 or higher