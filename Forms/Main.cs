using BreaksManager.Models;
using BreaksManager.Services;

namespace BreaksManager.Forms;

public partial class Main : Form
{
    private readonly EmployeesService _employeesService;

    public Main()
    {
        InitializeComponent();
        _employeesService = new();
        dataGridView.ShowCellToolTips = true;
    }

    private void btnAddEmployee_Click(object sender, EventArgs e)
    {
        var result = new EmployeeForm(_employeesService).ShowDialog();

        if (result is DialogResult.OK)
            UpdateDataGridView();
    }

    private void UpdateDataGridView() 
    {
        ClearDataGridView();
        SetEmployeeColumn();
        SetSelection();
        FillDataGridView();
    }

    private void ClearDataGridView() 
    {
        dataGridView.Columns.Clear();
        dataGridView.Rows.Clear();
    }

    private void SetEmployeeColumn() => dataGridView.Columns.Add(new DataGridViewTextBoxColumn
    {
        Name = "Employee",
        HeaderText = "Сотрудник",
        Width = 200,
        ReadOnly = true,
        Frozen = true
    });

    private void SetSelection()
    {
        if (_employeesService.EarliestClockIn is null || _employeesService.LatestClockOut is null)
            return;

        const int MinutesInDay = 24 * 60;

        var start = _employeesService.EarliestClockIn.Value;
        var end = _employeesService.LatestClockOut.Value;
        var startMin = (int)start.TotalMinutes;
        var endMin = (int)end.TotalMinutes;

        if (endMin <= startMin)
            endMin += MinutesInDay;

        var slotMinutes = (int)Slot.Size.TotalMinutes;

        for (int m = startMin; m < endMin; m += slotMinutes)
        {
            var displayTime = TimeSpan.FromMinutes(m % MinutesInDay);
            var col = new DataGridViewTextBoxColumn
            {
                Name = $"T_{m}",
                HeaderText = displayTime.ToString(@"hh\:mm"),
                Width = 40,
                ReadOnly = true
            };
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns.Add(col);
        }
    }

    private void FillDataGridView()
    {
        if (_employeesService.EarliestClockIn is null || _employeesService.LatestClockOut is null)
            return;

        const int MinutesInDay = 24 * 60;

        var start = _employeesService.EarliestClockIn.Value;
        var end = _employeesService.LatestClockOut.Value;
        var globalStart = (int)start.TotalMinutes;
        var globalEnd = (int)end.TotalMinutes;
        var slotMinutes = (int)Slot.Size.TotalMinutes;

        if (globalEnd <= globalStart)
            globalEnd += MinutesInDay;

        foreach (var employee in _employeesService.GetAll())
        {
            var rowIndex = dataGridView.Rows.Add();
            var row = dataGridView.Rows[rowIndex];

            row.Cells[0].Value = employee.Name;

            var empStart = (int)employee.ClockIn.TotalMinutes;
            var empEnd = (int)employee.ClockOut.TotalMinutes;

            if (empEnd <= empStart)
                empEnd += MinutesInDay;

            for (int col = 1; col < dataGridView.Columns.Count; col++)
            {
                var currentMinute = globalStart + (col - 1) * slotMinutes;
                var cell = row.Cells[col];

                if (currentMinute >= empStart && currentMinute < empEnd)
                {
                    var relativeMinute = currentMinute - empStart;
                    var slotIndex = relativeMinute / slotMinutes;

                    if (slotIndex >= 0 && slotIndex < employee.Slots.Count)
                    {
                        var slot = employee.Slots[slotIndex];

                        PaintCell(cell, slot.Activity);

                        var from = slot.Time;
                        var to = slot.Time + Slot.Size;

                        if (to >= TimeSpan.FromDays(1))
                            to -= TimeSpan.FromDays(1);

                        cell.ToolTipText =
                            $"{employee.Name}\n" +
                            $"{from:hh\\:mm}–{to:hh\\:mm}\n" +
                            $"Статус: {GetActivityName(slot.Activity)}";
                    }
                }
                else
                {
                    PaintCell(cell, Activity.Absent);

                    cell.ToolTipText =
                        $"{employee.Name}\nВне смены";
                }
            }
        }
    }

    private void PaintCell(DataGridViewCell cell, Activity activity)
    {
        cell.Value = string.Empty;
        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        cell.Style.BackColor = activity switch
        {
            Activity.Present => Color.LimeGreen,
            Activity.OnBreak => Color.Orange,
            _ => Color.White
        };
    }

    private string GetActivityName(Activity activity) => activity switch
    {
        Activity.Present => "Работает",
        Activity.OnBreak => "Перерыв",
        _ => "Отсутствует"
    };
}
