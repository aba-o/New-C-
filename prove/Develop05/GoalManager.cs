using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _aaoGoals;
    private int _aaoScore;
    private Menu _aaoMenu;

    public GoalManager()
    {
        _aaoGoals = new List<Goal>();
        _aaoScore = 0;
        _aaoMenu = new Menu();
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 7)
        {
            _aaoMenu.DisplayMainMenu(_aaoScore);
            choice = _aaoMenu.GetMenuChoice();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoals();
                    break;

                case 3:
                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;

                case 5:
                    RecordEvent();
                    break;

                case 6:
                    DisplayScore();
                    break;

                case 7:
                    _aaoMenu.DisplayMessage("Goodbye!");
                    break;

                default:
                    _aaoMenu.DisplayMessage("Invalid option.");
                    break;
            }
        }
    }

    // Prompts the user for goal type and details, then constructs
    // and stores the corresponding Goal subclass instance
    public void CreateGoal()
    {
        _aaoMenu.DisplayGoalTypes();

        int goalType = _aaoMenu.GetGoalTypeChoice();

        string name = _aaoMenu.PromptForString("What is the name of your goal? ");
        string description = _aaoMenu.PromptForString("What is a short description of it? ");
        int points = _aaoMenu.PromptForInt("How many points is it worth? ");

        switch (goalType)
        {
            case 1:
                _aaoGoals.Add(new SimpleGoal(name, description, points));
                break;

            case 2:
                _aaoGoals.Add(new EternalGoal(name, description, points));
                break;

            case 3:
                int targetAmount = _aaoMenu.PromptForInt("How many times does this goal need to be accomplished? ");
                int bonusPoints = _aaoMenu.PromptForInt("What is the bonus for accomplishing it? ");

                _aaoGoals.Add(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        targetAmount,
                        bonusPoints));

                break;

            default:
                _aaoMenu.DisplayMessage("Invalid goal type.");
                break;
        }

        _aaoMenu.DisplayMessage("Goal created successfully!");
    }

    public void ListGoals()
    {
        if (_aaoGoals.Count == 0)
        {
            _aaoMenu.DisplayMessage("No goals available.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Your Goals:");

        for (int i = 0; i < _aaoGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_aaoGoals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_aaoGoals.Count == 0)
        {
            _aaoMenu.DisplayMessage("No goals available.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Select a Goal:");

        for (int i = 0; i < _aaoGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_aaoGoals[i].GetName()}");
        }

        int choice = _aaoMenu.PromptForInt("Which goal did you accomplish? ");

        if (choice < 1 || choice > _aaoGoals.Count)
        {
            _aaoMenu.DisplayMessage("Invalid selection.");
            return;
        }

        int earnedPoints = _aaoGoals[choice - 1].RecordEvent();

        _aaoScore += earnedPoints;

        Console.WriteLine();
        Console.WriteLine($"Congratulations! You earned {earnedPoints} points.");
        Console.WriteLine($"Your total score is now {_aaoScore}.");
    }

    // Writes the current score and all goals (in a serialized,
    // pipe-delimited format defined by each goal) to a file
    public void SaveGoals()
    {
        string fileName = _aaoMenu.PromptForString("Enter filename: ");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_aaoScore);

            foreach (Goal goal in _aaoGoals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        _aaoMenu.DisplayMessage("Goals saved successfully.");
    }

    // Reads a previously saved file and reconstructs the score
    // and goal list, dispatching on the goal type stored in each line
    public void LoadGoals()
    {
        string fileName = _aaoMenu.PromptForString("Enter filename: ");

        if (!File.Exists(fileName))
        {
            _aaoMenu.DisplayMessage("File not found.");
            return;
        }

        _aaoGoals.Clear();

        string[] lines = File.ReadAllLines(fileName);
        // First line is always the saved score

        _aaoScore = int.Parse(lines[0]);
        
        // Remaining lines are pipe-delimited goal records,
        // starting with a type identifier
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal =
                    new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4]));

                _aaoGoals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal =
                    new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]));

                _aaoGoals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goal =
                    new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[4]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6]));

                _aaoGoals.Add(goal);
            }
        }

        _aaoMenu.DisplayMessage("Goals loaded successfully.");
    }

    public void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"Current Score: {_aaoScore}");
    }
}