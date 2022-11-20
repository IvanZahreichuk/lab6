namespace Lab06.Problem_4._Online_Radio_Database;

public class InvalidSongSecondsException : InvalidSongLengthException
{
    private const int MinSecondsValue = 0;
    private const int MazSecondsValue = 59;

    public override string Message => $"Song seconds should be between {MinSecondsValue} and {MazSecondsValue}.";
}