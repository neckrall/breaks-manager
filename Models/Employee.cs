using BreaksManager.Services;

namespace BreaksManager.Models;

public class Employee 
{
    private Slot[] _slots = [];

    public Employee(string name, TimeSpan clockIn, TimeSpan clockOut)
    {
        var validator = new ValidationService();

        Name = validator.ValidateName(name);
        ClockIn = validator.ValidateTime(clockIn);
        ClockOut = validator.ValidateTime(clockOut);

        var shiftDuration = ClockOut >= ClockIn ? ClockOut - ClockIn : (ValidationService.DAY_DURATION - ClockIn) + ClockOut;
        var slotsCount = (int)(shiftDuration.TotalMinutes / Slot.Size.TotalMinutes);
        var currentTime = ClockIn;

        _slots = new Slot[slotsCount];

        for (int i = 0; i < slotsCount; i++)
        {
            _slots[i] = new Slot
            {
                Time = currentTime,
                Activity = Activity.Present
            };

            currentTime += Slot.Size;

            if (currentTime >= ValidationService.DAY_DURATION)
                currentTime -= ValidationService.DAY_DURATION;
        }
    }

    public string Name { get; }
    public TimeSpan ClockIn { get; }
    public TimeSpan ClockOut { get; }
    public IReadOnlyList<Slot> Slots => _slots;
}
