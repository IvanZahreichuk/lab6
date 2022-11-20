namespace Lab06.Problem_4._Online_Radio_Database;

public class Song
{
    private string _artistName;
    private string _songName;
    private int _minutes;
    private int _seconds;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public string ArtistName
    {
        get => this._artistName;
        private set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }

            this._artistName = value;
        }
    }

    public string SongName
    {
        get => this._songName;
        private set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }

            this._songName = value;
        }
    }

    public int Minutes
    {
        get => this._minutes;
        private set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }

            this._minutes = value;
        }
    }

    public int Seconds
    {
        get => this._seconds;
        private set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }

            this._seconds = value;
        }
    }
}