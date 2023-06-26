
using BMICalculator.Models;

namespace BMICalculator.ViewModels;

public class BMIViewModel
{
    public BMI BMI { get; set; }

    public BMIViewModel()
    {
        BMI = new();
    }
}
