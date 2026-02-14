namespace BreaksManager.Services;

internal class ValidationService
{
    public static readonly TimeSpan MIN_TIME = new TimeSpan(0, 0, 0);
    public static readonly TimeSpan MAX_TIME = new TimeSpan(23, 59, 59);
    public static readonly TimeSpan DAY_DURATION = TimeSpan.FromHours(24);
    public static readonly TimeSpan FULL_SHIFT_DURATION = TimeSpan.FromHours(12);

    public string ValidateName(string name) 
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new Exception("ФИО сотрудника не может быть пустым.");

        return name.Trim();
    }

    public TimeSpan ValidateTime(TimeSpan time) 
    { 
        if (time < MIN_TIME || time > MAX_TIME)
            throw new Exception("Время не может быть за пределами суток");

        return time;
    }
}
