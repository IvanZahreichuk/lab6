namespace Lab06.Problem_5._Mordors_Cruel_Plan;

public abstract class Food : IFood
{
    protected Food(int happiness)
    {
        this.Happiness = happiness;
    }

    public int Happiness { get; set; }
}