using BreaksManager.Models;

namespace BreaksManager.Services;

public class EmployeesService
{
    private List<Employee> _employees = new();

    public TimeSpan? EarliestClockIn => _employees.Count == 0 ? null : _employees.Min(e => e.ClockIn);

    public TimeSpan? LatestClockOut
    {
        get
        {
            if (_employees.Count == 0)
                return null;

            var latest = _employees
                .Select(e =>
                {
                    var end = e.ClockOut;

                    if (e.ClockOut < e.ClockIn)
                        end += ValidationService.DAY_DURATION;

                    return end;
                }).Max();

            return latest >= ValidationService.DAY_DURATION ? latest - ValidationService.DAY_DURATION : latest;
        }
    }

    public void AddEmployee(string name, TimeSpan clockIn, TimeSpan clockOut) => _employees.Add(new Employee
    (
        name: name,
        clockIn: clockIn,
        clockOut: clockOut
    ));

    public IReadOnlyList<Employee> GetAll() => _employees.OrderBy(e => e.Name).ToList();
}
