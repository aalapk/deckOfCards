Deck of Cards

1. The application is created using C#.Net, in Visual Studio.
2. The application supports multi-deck scenarios where you may want to have master deck with multiple sets of 52 cards
2. Important functions for a deck: initialization, shuffle, draw a card, put a card back

Installation requirements and instructions:
1. The application is created in Visual Studio (C# Windows Forms project) using .Net Framework 4.5.2. To run the application (and tests), the best way is to open download/clone the repository and open the .sln file in Visual Studio. A community edition of Visual Studio can be used for this. .Net framework is required (> 4.5).
2. The application uses NUnit 3 Framework for tests. NUnit framework is installed through NuGet. Tests are maintained in a seperate Test project (DeckOfCardsTests), which is part of the same solution.
3. The best way to run and verify all the tests is through Test explorer from inside Visual Studio: Test -> Run -> All Tests
4. The application can be started by clicking the green 'Start' button. The entry point for this Windows Forms application is class Program.cs 
5. In absense of Visual Studio, the application can be built from command line as follows:
  (i) Navigate to the folder containing the project .sln file
  (ii) Run command: Complete_Path_to_msbuild DeckOfCards.sln /p:Configuration=Release (or Debug). Ignore Nunit errors/warning
  (iii) cd DeckOfCards/bin/Relase (or debug)
  (iv) Run DeckOfCards.exe. This should open the application window.
Sample path to msbuild: C:\Windows\Microsoft.NET\Framework\v4.0.30319.
Running Nunit tests from command line would need a third party application such as nunit-console.exe. Using Visual Studio for running tests and the application is much cleaner.
