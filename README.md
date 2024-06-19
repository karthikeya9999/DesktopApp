
# Slidely Form App

This is a Windows Desktop Application built using Visual Basic in Visual Studio. The application allows users to create new submissions and view existing submissions. The application features keyboard shortcuts for ease of use.

## Features

- **Create New Submissions**: Users can input their name, email, phone number, GitHub repository link, and track time using a stopwatch.
- **View Submissions**: Users can navigate through previously submitted entries.
- **Keyboard Shortcuts**:
  - `Ctrl + N` to create a new submission.
  - `Ctrl + S` to submit the form.
  - `Ctrl + V` to view submissions.
  - `Ctrl + T` to start/stop the stopwatch.
  - `Ctrl + P` to view the previous submission.
  - `Ctrl + N` to view the next submission.

## Installation

1. **Clone the Repository**:

    ```sh
    git clone https://github.com/your-username/your-repo-name.git
    ```

2. **Open the Project in Visual Studio**:
    - Open Visual Studio.
    - Select `File > Open > Project/Solution`.
    - Navigate to the cloned repository and select the solution file (`.sln`).

3. **Restore NuGet Packages**:
    - Right-click on the solution in the Solution Explorer.
    - Select `Restore NuGet Packages`.

4. **Build the Solution**:
    - Click on `Build > Build Solution` or press `Ctrl + Shift + B`.

## Usage

1. **Run the Application**:
    - Press `F5` or select `Debug > Start Debugging`.

2. **Create a New Submission**:
    - Click on the `Create New Submission` button or press `Ctrl + N`.
    - Fill in the required fields: Name, Email, Phone Number, GitHub Link.
    - Use the stopwatch to track time, if necessary.
    - Click on `Submit` or press `Ctrl + S` to submit the form.

3. **View Submissions**:
    - Click on the `View Submissions` button or press `Ctrl + V`.
    - Navigate through submissions using the `Previous` (`Ctrl + P`) and `Next` (`Ctrl + N`) buttons.

## File Structure

- **Main Form** (`Form1.vb`):
    - Contains the main interface with buttons to create a new submission and view submissions.
- **Create Submission Form** (`CreateSubmissionsForm.vb`):
    - Contains the form for creating new submissions with input fields and a stopwatch.
- **View Submissions Form** (`ViewSubmissionsForm.vb`):
    - Contains the form for viewing existing submissions with navigation controls.
- **Submission Class** (`Submission.vb`):
    - Defines the structure of a submission.

## Screenshots

### Main Form

![Main Form](path/to/main-form-screenshot.png)

### Create Submission Form

![Create Submission Form](path/to/create-submission-form-screenshot.png)

### View Submissions Form

![View Submissions Form](path/to/view-submissions-form-screenshot.png)

## Contributing

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Open a pull request.
