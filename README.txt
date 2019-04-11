# Description about applicaton

Visual Studio 2017

There are three project in GameApp application.
1. GameApp (Console Project) for User UI
2. Service Layer (Class library project) it contains classes, enum, interface and methods for game rules and data 
3. UnitTestGame (UnitTest project) for test cases

Applied below SOLID principles,
1. SRP - Single responsibility principle (every class have only one task) like classes Validation, ComputerPlayers, RulesItemMapData, Result
2. OCP - Open and Close principle, easy for extension and closed for modification. Interface IResult has one method and but have differnt functionality, 
         used in both classes GameResult and Result.
3. ISP - Interface Seggration principle (Interfaces IResult and IFinalResult applied in GameResult class ), IFinalResult interface is not required for Result class 
         but IResult required for Result class. If both Interfaces merge then has to implement all methods in classes like (Result class)

Used Collection and LINQ.

Testing:
Total 11 Unit Test cases have created.
1. Items - test valid Item
2. RulesTest - test rule of Rock-Paper-Scissors
3. GamesTest - test player using Human Player or Computer Player

