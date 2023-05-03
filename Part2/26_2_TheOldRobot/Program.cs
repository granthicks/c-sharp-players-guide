public class Robot
{
 public int X { get; set; }
 public int Y { get; set; }
 public bool IsPowered { get; set; }
 public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
 public void Run()
 {
 foreach (RobotCommand? command in Commands)
 {
 command?.Run(this);
 Console.WriteLine($"[{X} {Y} {IsPowered}]");
 }
 }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
    {
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
    {
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;
        }
    }
}

public class SouthCommand : RobotCommand
    {
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y--;
        }
    }
}

public class EastCommand : RobotCommand
    {
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X++;
        }
    }
}

public class WestCommand : RobotCommand
    {
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X--;
        }
    }
}

public class Program
    {
    public static void Main()
    {
        Robot robot = new Robot();

        Console.WriteLine("Robot commands: on, off, north, south, east, west");

        for (int i = 0; i < robot.Commands.Length; i++)
        {
            Console.WriteLine("Enter command:");
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "on":
                    robot.Commands[i] = new OnCommand();
                    break;
                case "off":
                    robot.Commands[i] = new OffCommand();
                    break;
                case "north":
                    robot.Commands[i] = new NorthCommand();
                    break;
                case "south":
                    robot.Commands[i] = new SouthCommand();
                    break;
                case "east":
                    robot.Commands[i] = new EastCommand();
                    break;
                case "west":
                    robot.Commands[i] = new WestCommand();
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    i--;
                    break;
            }
        }

        robot.Run();
    }
}
