# Git Source Control Simulation

This project simulates a simplified version of a Git-like source control system, allowing users to create branches, make commits, and manage file states such as Draft, Staged, Committed, Under Review, etc. The system demonstrates the use of design patterns like Command and State for managing file state transitions and handling actions such as commits, merges, and reviews.

## Features

- **Branch Management**: Create, delete, and manage different branches.
- **File States**: Track file states (Draft, Staged, Committed, Under Review, etc.) as the file progresses through the versioning system.
- **State Transitions**: Ensure files go through the appropriate states, such as review and commit.
- **History Tracking**: Keep track of the file's state changes and allow users to roll back changes to previous states.
- **Review Workflow**: Implement a review process where a file is reviewed before it is merged into the main branch.
- **Command Pattern**: Actions like commit, merge, and file state transitions are encapsulated as commands.
- **Undo Feature**: Ability to undo actions like commits and state transitions.

## Requirements

- .NET 8 or higher
- Visual Studio 2022 or later (recommended for .NET development)

## Folder Structure

The project is structured as follows:

Git_Source_Control │ ├── Models │ ├── FileState │ │ ├── CommittedState.cs │ │ ├── DraftState.cs │ │ └── OtherState.cs │ └── File.cs │ ├── Patterns │ ├── Command │ │ ├── ICommand.cs │ │ ├── FileCommand.cs │ └── Program.cs

- **Models/FileState**: Contains classes that represent different file states (e.g., CommittedState, DraftState).
- **Models/File**: The main `File` class that manages the state of a file.
- **Patterns/Command**: Implements the Command Pattern for actions such as commit, undo, and state transitions.
- **Program.cs**: The entry point of the application where branches and file operations are performed.

## Setup

1. **Clone the repository**:
    ```bash
    git clone https://github.com/FriedmanChani/Design-Patterns.git
    cd Design-Patterns
    ```

2. **Open the project in Visual Studio**:

3. **Install dependencies**:
    The project uses .NET 8, which should already be installed if you're using the recommended version of Visual Studio. Otherwise, install the appropriate SDK version from the [official site](https://dotnet.microsoft.com/download/dotnet).

4. **Build the project**:
    Build the solution by selecting **Build > Build Solution** in Visual Studio.

## Usage

1. **Running the application**:
   Once the solution is built, you can run the application by pressing **Ctrl+F5** in Visual Studio.

2. **Branch Management**:
   You can create a new branch by calling `CreateBranch(string branchName)` and delete branches with `DeleteBranch(string branchName)`.

3. **File Management**:
   - Create a new file with `File file = new File()`.
   - Change its state using `file.ChangeState(new CommittedState())` to transition it to different stages like Draft, Staged, or Committed.
   
4. **File Operations**:
   - **Commit**: Use the `Commit` action to commit changes to a file.
   - **Undo Commit**: Undo the last commit using `Undo()`.
   - **Request Review**: Initiate the review process by calling `RequestReview()`.

## Design Patterns

### Command Pattern

The **Command Pattern** is used to encapsulate actions like commit, merge, and file state transitions into objects. This allows operations to be parameterized with different inputs, stored, and executed at a later time.

- **ICommand Interface**: Defines the basic contract for all commands, with `Execute()` and `Undo()` methods.
- **FileCommand Class**: Represents a command to modify the state of a file. This class executes the action on the file and allows for undoing that action.
  
By implementing the Command Pattern, actions such as committing changes, undoing commits, or changing file states can be tracked and reversed if needed.

### State Pattern

The **State Pattern** is used to manage the different states of a file (e.g., Draft, Staged, Committed). Instead of having complex conditionals in the `File` class, each state is represented by its own class that implements a common interface.

- **FileState Class**: The base class that defines common operations for all states.
- **Concrete State Classes (e.g., CommittedState, DraftState)**: Implement the state-specific behavior, such as transitions to other states.
- **File Class**: Holds a reference to the current state and delegates the state-specific actions to the state objects. This allows the file to change its state dynamically without modifying the `File` class logic.

The State Pattern makes it easier to manage the transitions between various stages in the file’s lifecycle and enforces rules about the allowed state transitions (for example, a file cannot skip review and jump directly to commit).

## Contributing

Feel free to fork the repository and submit pull requests with improvements, bug fixes, or new features. If you have any suggestions or issues, please open an issue in the GitHub repository.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or feedback, feel free to open an issue or reach out to me directly via GitHub.




