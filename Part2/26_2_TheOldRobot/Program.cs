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

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("ROBOT COMMANDS");
            Console.WriteLine("1. On");
            Console.WriteLine("2. Off");
            Console.WriteLine("3. North");
            Console.WriteLine("4. South");
            Console.WriteLine("5. East");
            Console.WriteLine("6. West");
        
            Console.Write("Enter command: ");
            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 1:
                    robot.Commands[i] = new OnCommand();
                    break;
                case 2:
                    robot.Commands[i] = new OffCommand();
                    break;
                case 3:
                    robot.Commands[i] = new NorthCommand();
                    break;
                case 4:
                    robot.Commands[i] = new SouthCommand();
                    break;
                case 5:
                    robot.Commands[i] = new EastCommand();
                    break;
                case 6:
                    robot.Commands[i] = new WestCommand();
                    break;
            }
        }
    }
}
