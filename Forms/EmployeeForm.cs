using BreaksManager.Services;

namespace BreaksManager.Forms;

public partial class EmployeeForm : Form
{
    private readonly EmployeesService _employeesService;

    public EmployeeForm(EmployeesService employeesService)
    {
        InitializeComponent();
        _employeesService = employeesService; 
        inputClockIn.ValueChanged += InputClockIn_ValueChanged;
    }

    private void InputClockIn_ValueChanged(object? sender, EventArgs e)
    {
        var clockIn = inputClockIn.Value;
        var clockOut = clockIn.Add(ValidationService.FULL_SHIFT_DURATION);
        inputClockOut.Value = clockOut;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        try 
        {
            _employeesService.AddEmployee(nameInput.Text, inputClockIn.Value.TimeOfDay, inputClockOut.Value.TimeOfDay);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
