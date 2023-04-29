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

public class RobotCommand
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

public class NorthCommand
    {
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;
        }
    }
}

public class SouthCommand
    {
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y--;
        }
    }
}

public class EastCommand
    {
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X++;
        }
    }
}

public class WestCommand
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
    robot.Commands[0] = new OnCommand();
    robot.Commands[1] = new NorthCommand();
    robot.Commands[2] = new OffCommand();
    robot.Run();
    }
}
