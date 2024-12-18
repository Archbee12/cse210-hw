using System;

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void Start()
  {
    while (true)
    {
      Console.WriteLine($"\nYou have {_score} points");

      Console.WriteLine("\nMenu Options:");
      Console.WriteLine("1. Create New Goal");
      Console.WriteLine("2. List Goals");
      Console.WriteLine("3. Save Goals");
      Console.WriteLine("4. Load Goals");
      Console.WriteLine("5. Record Event");
      Console.WriteLine("6. Quit");
      Console.Write("Select a choice from the menu: ");
      string user = Console.ReadLine();

      if (user == "1")
      {
        CreateGoal();
      }

      else if (user == "2")
      {
        ListGoals();
      }
      else if (user == "3")
      {
        SaveGoals();
      }
      else if (user == "4")
      {
        LoadGoals();
      }
      else if (user == "5")
      {
        RecordEvent();
      }
      else if (user == "6")
      {
        return;
      }
      else
      {
        Console.WriteLine("Invalid choice. Please try again.");
      }
    }
  }

  public void DiplayPlayerInfo()
  {
    Console.WriteLine($"Player Info: Score = {_score}, Total Goals = {_goals.Count}");
  }

  public void ListGoalNames()
  {
    Console.WriteLine("Goal Names:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation().Split('|')[1]}");
    }
  }

  public void ListGoalDetails()
  {
    Console.WriteLine("Goal Detials:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine(_goals[i].GetDetailsString());
    }
  }

  private void CreateGoal()
  {
    string _goalType;

    while(true)
    {
      Console.WriteLine("\nThe types of Goals are:");
      Console.WriteLine("1. Simple Goal");
      Console.WriteLine("2. Eternal Goal");
      Console.WriteLine("3. Checklist Goal");
      Console.Write("Which type of goal would you like to create? ");
      _goalType = Console.ReadLine();

      if (_goalType == "1" || _goalType == "2" || _goalType == "3")
      {
        break;
      }

      else
      {
        Console.WriteLine("Invalid goal type, please try again.");
      }
    }
    
    Console.Write("What is the name of your goal? ");
    string _name = Console.ReadLine();
    Console.Write("What is a short description of it? ");
    string _description = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    int _points = int.Parse(Console.ReadLine());

    if (_goalType == "1")
    {
      _goals.Add(new SimpleGoal(_name, _description, _points));
    }

    else if (_goalType == "2")
    {
      _goals.Add(new EternalGoal(_name, _description, _points));
    }

    else if (_goalType == "3")
    {
      Console.Write("How many times does this goal needs to be accomplished for a bonus? ");
      int _target = int.Parse(Console.ReadLine());
      Console.Write("Enter bonus point: ");
      int _bonus = int.Parse(Console.ReadLine());
      _goals.Add(new ChecklistGoal(_name, _description, _points, _target, _bonus));
    }

    Console.WriteLine("Goal added successfully.");
  }

  private void ListGoals()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("\nNo goals available to list.");
      return;
    }

    Console.WriteLine("\n--- List of Goals ---");
    ListGoalDetails();
  }

  public void AddGoal(Goal goal)
  {
    _goals.Add(goal);
  }

  public void RecordEvent()
  {
    Console.WriteLine("\nWhich Goal did you accomplish:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    int user = int.Parse(Console.ReadLine()) - 1;
    if (user >= 0 && user < _goals.Count)
    {
      _goals[user].RecordEvent();
      _score += _goals[user] is ChecklistGoal checklist && checklist.IsComplete()
          ? checklist.GetPoints() + checklist._bonus
          : _goals[user].GetPoints();
      Console.Write("Select a choice from the goal: ");
    }
    else
    {
      Console.WriteLine("Invalid goal: Please try again");
    }
    
  }  

  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      writer.WriteLine(_score);
      foreach (var goal in _goals)
      {
        writer.WriteLine(goal.GetStringRepresentation());
      }
    }
    Console.WriteLine($"Goals successfully saved to {fileName}.");
  }

  private void LoadGoals()
  {
    Console.Write("Enter filename to load: ");
    string fileName = Console.ReadLine();

    if (!File.Exists(fileName))
    {
      Console.WriteLine("File not found. No data loaded.");
      return;
    }

    else 
    {
      Console.WriteLine("Goals loaded successfully!");
    }

    _goals.Clear();

    using (StreamReader reader = new StreamReader(fileName))
    {
      _score = int.Parse(reader.ReadLine()); // Load score
      string line;
      while ((line = reader.ReadLine()) != null)
      {
        string[] parts = line.Split('|');
        if (parts[0] == "SimpleGoal")
        {
          bool isComplete = bool.Parse(parts[4]);
          var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
          if (isComplete) goal.RecordEvent();
          _goals.Add(goal);
        }
        else if (parts[0] == "EternalGoal")
        {
          _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
        }
        else if (parts[0] == "ChecklistGoal")
        {
          int amountCompleted = int.Parse(parts[4]);
          int target = int.Parse(parts[5]);
          int bonus = int.Parse(parts[6]);
          var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), target, bonus);
          for (int i = 0; i < amountCompleted; i++) goal.RecordEvent();
          _goals.Add(goal);
        }
        Console.WriteLine(line);
      }
    }

    // Console.WriteLine("Goals loaded successfully.");
  }



}