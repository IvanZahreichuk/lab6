﻿namespace Lab06.Problem_4._Online_Radio_Database;

public class InvalidSongNameException : InvalidSongException
{
    private const int MinNameLength = 3;
    private const int MaxNameLength = 30;

    public override string Message => $"Song name should be between {MinNameLength} and {MaxNameLength} symbols.";
}