# Deck of Cards

1. The application is created using C#.Net, in Visual Studio.
2. The application supports multi-deck scenarios where you may want to have a master deck with multiple decks of 52 cards.
3. An integer parameter in Program.cs determines the number of decks to use in the master deck (currently coded to 1). 
*Application.Run(new MainMenu(new DeckOfCards(**1**)));*
This can easily be changed to verify multi-deck scenarios.
2. Important functions for a deck: initialization, shuffle, draw a card, put a card back

## Installation and run instructions:

The application is created in Visual Studio (C# Windows Forms project) using .Net Framework 4.5.2. The application uses NUnit 3 Framework for tests (managed automatically through NuGet package manager). Tests are maintained in a seperate Test project (DeckOfCardsTests), which is part of the same solution.

**Running the application with Visual Studio** (Recommended)

1. Make sure that .Net Framework is installed. Version 4.5 or higher is needed to build the application.
2. Download and unzip the repository anywhere on a machine
3. Navigate to the unzipped folder, and go inside folder 'deckOfCards-master'
4. Open file DeckOfCardsDemo.sln in Visual Studio
5. Build the solution
6. Run all tests: Test -> Run -> All Tests. All should pass.
7. Run the application by clicking the green 'Start' button. The entry point for this Windows Forms application is class Program.cs. The interactive Windows Forms application lets you verify the underlying functionality of the application through a simple UI.

**Building and running through command line**

The application can be built and run from a command line. Tests can be verified using command line as well.

1. Make sure that .Net Framework is installed. Version 4.5 or higher is needed to build the application.
2. Download and unzip the repository anywhere on a machine
3. Open a command prompt, navigate to the unzipped folder, and go inside folder 'deckOfCards-master' (root for DeckOfCardsDemo.sln)
4. Run command: *nuget restore DeckOfCardsDemo.sln* This downloads packages needed for running tests. 
5. Now the application needs to be built using **MSBuild** utility. It's typically present at *C:\Windows\Microsoft.NET\Framework* and then inside a version folder.
6. Run the following command: *Complete_Path_to_msbuild* DeckOfCards.sln /p:Configuration=Release. This will build the application
7. To run tests through command line, a utility called NUnit.Consolerunner is packaged. It should have downloaded after step 4. Run the following command: *Base_Folder*\packages\NUnit.ConsoleRunner.3.8.0\tools\nunit3-console.exe *Base_Folder*\DeckOfCardsTest\bin\Release\DeckOfCardsTest.dll
This should run the NUnit tests and you should see the outcome in the command prompt. The important piece in the above command is to provide absolute paths for **nunit3-console.exe** and **DeckOfCardsTest.dll**
8. Run the application by invoking the .exe file at *Root_Path*\DeckOfCards\bin\Release\DeckOfCards.exe. This should open the interactive Windows Forms application that lets you verify the underlying functionality of the application through a simple UI.
