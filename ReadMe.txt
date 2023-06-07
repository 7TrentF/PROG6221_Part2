--------------------------------------
Trents Recipe Console Application
--------------------------------------
Minimum System requirements:

Operating system= Windows 8.1, 10, 11).
Microsift Visual Studio 2022

[Minimum requirements to able to run Microsoft Visual Studio 2022]
Windows 11 version 21H2 or higher: Home, Pro, Pro Education, Pro for Workstations, Enterprise, and Education
Windows 10 version 1909 or higher: Home, Professional, Education, and Enterprise. 
Windows Server(2022, 2019, 2016: Standard and Datacenter)

[Minimum hardware requirements to be able to run Visual Studio 2022]
A Processor that is 1.8GHz or faster 
Quad-core or better recommended
Minimum of 4 GB of RAM but 8GB of RAM is recommended
Hard disk space: Minimum of 850 MB up to 210 GB of available space, depending on features installed; typical installations require 20-50 GB of free space.
Recommended installing Windows and Visual Studio on a solid-state drive (SSD) to increase performance, but an HDD will suffice as well.
Video card that supports a minimum display resolution of WXGA (1366 by 768); Visual Studio will work best at a resolution of 1920 by 1080 or higher.


This is a simple console application for managing recipe details. The application allows you to enter the details for a single recipe, display the recipe, scale the recipe, reset quantities, and clear all data to enter a new recipe.

Usage/ How to run 
To use the application, simply run the RecipeConsoleApp file by opening it through Visual Studio.
You will be presented with the raw code and you will only need to run it through executing the code by clicking on 'start wihout debugging' next to 'start' at the top of the screen.
You will be presented with a menu of options upon running the code:

Type:" 'add' to add a new recipe,
       'list' to display all recipes,
       'display' to view a specific recipe,  
        or 'exit' to quit:");

Enter one of the four commands presented to proceed.

------------------------------------------------------------------------------------------------------------
UPDATES!!!
------------------------------------------------------------------------------------------------------------
The following updates have been made to the program, in addition to the functions from the first version:

1. Users are now able to enter an unlimited number of recipes.
2. Enter a name for each Recipe. 
3. Display a list of all the recipes to the user in alphabetical order by name.
4. Choose which recipe to display from the list.
5. For each ingredient, enter:
   a. The number of calories, and
   b. The food group that the ingredient belongs to. 
6. Calculate and display the total calories of all the ingredients in a recipe.
7. Be notified if the total calories of a recipe exceed 300.
-------------------------------------------------------------------------------------------------------------
Notes:
The application does not persist data between runs. All data is stored in memory while the application is running.
The application is written in C# and requires the .NET Framework to be installed on your system.
The application may not handle invalid input gracefully. Please enter valid input when prompted to do so. If there is any other input other than suggested, you may run into errors.


License:
This application is licensed under the MIT License. See the LICENSE file for details.
-------------------------------------------------------------------------------------------------------------
Changes made based on the Lecturers Feedback:
Based on the Lectures feedback from Part 1, I have added the function that allows the user to clear a recipe if they choose to do so. 
The method has been added to the Recipe class, which contains a prompt asking the user if they would like to clear the recipe they have added. 
If the user answers ‘yes’ to the prompt then the recipe name, ingredients, and steps that have been added to the recipe so far will be cleared completely.
