namespace Lab06.Problem_5._Mordors_Cruel_Plan;

public static class MoodFactory
{
    public static void ChangeMood(IMood person, IList<IFood> foods)
    {
        foreach (var food in foods)
        {
            person.Mood += food.Happiness;
        }
    }
}