namespace POOTIME;

public class Time
{
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;

    public Time()
    {
        _hour = 0;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
    }
    public Time(int hour)
    {
        _hour = hour;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
    }

    public Time(int hour, int minute)
    {
        _hour = hour;
        _minute = minute;
        _second = 0;
        _millisecond = 0;
    }

    public Time(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = 0;
    }

    public Time(int hour, int minute, int second, int millisecond)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
    }

    public int Hour
    {
        get => _hour;
        set => _hour = value;
    }

    public int Minute
    {
        get => _minute;
        set => _minute = value;
    }

    public int Second
    {
        get => _second;
        set => _second = value;
    }

    public int Millisecond
    {
        get => _millisecond;
        set => _millisecond = value;
    }

    public override string ToString()
    {
        if (_hour < 0 || _hour > 23 || _minute < 0 || _minute > 59 || _second < 0 || _second > 59 || _millisecond < 0 || _millisecond > 999)
        {
            throw new ArgumentException("Hora no válida.");
        }

        string schedule = _hour >= 12 ? "PM" : "AM";
        int displayHour = _hour % 12;
        if (displayHour == 0) displayHour = 12;
        string timeString = $"{displayHour:00}:{_minute:00}:{_second:00}.{_millisecond:000} {schedule}";
        return timeString;
    }

    public int ToMilliseconds()
    {
        return _hour * 3600000 + _minute * 60000 + _second * 1000 + _millisecond;
    }

    public int ToSeconds()
    {
        return _hour * 3600 + _minute * 60 + _second;
    }

    public int ToMinutes()
    {
        return _hour * 60 + _minute;
    }

    public Time Add(Time other)
    {
        int totalMilliseconds = (int)(this.ToMilliseconds() + other.ToMilliseconds());

        int newHours = (totalMilliseconds / (1000 * 3600)) % 24;
        totalMilliseconds %= (1000 * 3600);
        int newMinutes = totalMilliseconds / (1000 * 60);
        totalMilliseconds %= (1000 * 60);
        int newSeconds = totalMilliseconds / 1000;
        int newMilliseconds = totalMilliseconds % 1000;

        return new Time(newHours, newMinutes, newSeconds, newMilliseconds);
    }

}