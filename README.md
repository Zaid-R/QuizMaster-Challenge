# QuizMaster

## Purpose of the Program
<h4 style="display:inline;">QuizMaster</h4> is a simple console-based quiz application written in C#. The program presents a series of questions to the user, who must answer each within a specified time limit. If the user fails to answer within the time limit, the program automatically moves to the next question. The user's score is calculated based on the number of correct answers provided.

## Instructions on How to Run the Program
### 1. Clone the Repository:
If the code is hosted on a platform like GitHub, clone the repository to your local machine using:
`git clone <repository_url>`

### 2. Open the Project:
Open the project in your preferred C# development environment, such as Visual Studio or Visual Studio Code.
### 3. Build the Project:
Ensure that all dependencies are installed and build the project. In Visual Studio, you can do this by selecting Build > Build Solution from the menu.
### 4. Run the Program:
Run the program by pressing F5 in Visual Studio or by using the terminal/command prompt:
`dotnet run`

### 5. Answer the Questions:
- The program will display each question and give you 5 seconds to answer. Type your answer and press Enter.
- If you do not provide an answer within the time limit, the program will move to the next question automatically.
- The program will notify you if your answer is correct or incorrect and will display your final score at the end.
### Additional Information
- ####  Handling Empty Answers:
  - The program ensures that the user cannot leave their answer empty. If an empty answer is provided, the user is prompted to try again until a valid answer is given.
- #### Asynchronous Timer:
  - The program uses asynchronous programming to handle the timer and user input concurrently, ensuring a smooth user experience.
- #### Extending the Quiz:
  - You can easily extend the quiz by adding more questions and answers to the questions and answers lists in the StartQuiz method.
- #### Error Handling:
  - The program includes basic error handling to catch and display any exceptions that may occur during execution.

	- Feel free to modify and enhance the program as needed. Enjoy your quiz!