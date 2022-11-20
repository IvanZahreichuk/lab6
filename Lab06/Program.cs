using Lab06;
using Lab06.Problem_2._Book_Shop;
using Lab06.Problem_3._Mankind;
using Lab06.Problem_4._Online_Radio_Database;
using Lab06.Problem_5._Mordors_Cruel_Plan;

var loopBreak = true;
while (loopBreak)
{
    Console.WriteLine("Select the problem(1-5) or exit(0):");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Problem1();
            break;
        case 2:
            Problem2();
            break;
        case 3:
            Problem3();
            break;
        case 4:
            Problem4();
            break;
        case 5:
            Problem5();
            break;
        default:
            Console.WriteLine("Exiting the Lab 6...");
            loopBreak = false;
            break;
    }

    if (!loopBreak) break;
}

// Problem 1
void Problem1()
{
    Console.WriteLine("Problem 1");
    Console.WriteLine("Input name: ");
    var name = Console.ReadLine();
    Console.WriteLine("Input age: ");
    var age = int.Parse(Console.ReadLine());

    try
    {
        var child = new Child(name, age);
        Console.WriteLine(child);
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
}

// Problem 2
void Problem2()
{
    Console.WriteLine("Problem 2");
    try
    {
        Console.WriteLine("Input author:");
        var author = Console.ReadLine();
        Console.WriteLine("Input title:");
        var title = Console.ReadLine();
        Console.WriteLine("Input price:");
        var price = decimal.Parse(Console.ReadLine());

        var book = new Book(author, title, price);
        var goldenEditionBook = new GoldenEditionBook(author, title, price);

        Console.WriteLine(book);
        Console.WriteLine(goldenEditionBook);
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
}

//Problem 3
void Problem3()
{
    Console.WriteLine("Problem 3");
    Console.WriteLine("Input student info:");
    Console.WriteLine("Name / Surname / Faculty number");
    var inputLine = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    var firstName = inputLine[0];
    var lastName = inputLine[1];
    var facultyNumber = inputLine[2];
    Student student;
    try
    {
        student = new Student(firstName, lastName, facultyNumber);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return;
    }

    Console.WriteLine("Input worker info:");
    Console.WriteLine("Name / Surname / Week Salary / Working hours");
    inputLine = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    firstName = inputLine[0];
    lastName = inputLine[1];
    var weekSalary = double.Parse(inputLine[2]);
    var hoursPerDay = double.Parse(inputLine[3]);
    Worker worker;
    try
    {
        worker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return;
    }

    Console.WriteLine(student);
    Console.WriteLine(worker);
}

//Problem 4
void Problem4()
{
    Console.WriteLine("Problem 4");
    Console.WriteLine("Input songs count:");

    var songs = new List<Song>();
    var songsCount = int.Parse(Console.ReadLine());

    for (int i = 0; i < songsCount; i++)
    {
        Console.WriteLine("Artist / Song / Time: ");
        var input = Console.ReadLine().ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        try
        {
            var time = input[2].Split(':').ToArray();
            int digit1;
            int digit2;

            if (int.TryParse(time[0], out digit1) && int.TryParse(time[1], out digit2))
            {
                if (digit1 * 60 + digit2 > 0 || digit1 * 60 + digit2 < 14 * 60 + 59)
                {
                    songs.Add(new Song(input[0], input[1], digit1, digit2));
                    Console.WriteLine("Song added.");
                }
            }
            else
            {
                throw new InvalidSongLengthException();
            }
        }
        catch (Exception ise)
        {
            Console.WriteLine(ise.Message);
        }
    }

    var totalDuration = songs.Sum(x => x.Minutes * 60 + x.Seconds);

    var totalHours = totalDuration / 60 / 60;
    var totalMinutes = (totalDuration / 60) - (totalHours * 60);
    long totalSeconds = totalDuration % 60;


    Console.WriteLine($"Songs added: {songs.Count}");
    Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
}

//Problem 5
void Problem5()
{
    Console.WriteLine("Problem 5");
    Console.WriteLine("Input Gandalf's foods he has eaten separated by a whitespace:");

    string input = Console.ReadLine();

    var gandalf = new Gandalf();

    var foods = FoodFactory.ProduceFood(input);
    MoodFactory.ChangeMood(gandalf, foods);

    Console.WriteLine(gandalf);
}