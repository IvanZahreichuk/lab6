namespace Lab06.Problem_4._Online_Radio_Database;

public class InvalidSongException : Exception
{
    private string exceptionMessage = "Invalid song.";

    public virtual string ExceptionMessage
    {
        set => this.exceptionMessage = value;
    }

    public override string Message => exceptionMessage;
}