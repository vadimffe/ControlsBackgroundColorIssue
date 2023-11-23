using ControlsBackgroundColorIssue.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsBackgroundColorIssue.ViewModels
{
  public class MainViewModel : BaseViewModel
  {
    public MainViewModel()
    {
      this.SColors = new ObservableCollection<ColorModel>
      {
        new ColorModel
        {
          ColorName = "Green", ColorValue = Colors.Green
        },
        new ColorModel
        {
          ColorName = "Dark Red", ColorValue = Colors.DarkRed
        },
        new ColorModel
        {
          ColorName = "Violet", ColorValue = Colors.Purple
        }
      };

      this.stepperValue = 0;
      this.IsCounted = true;
      this.SelectedColor = this.SColors.First();
    }

    private ObservableCollection<ColorModel> sColors;
    public ObservableCollection<ColorModel> SColors
    {
      get => this.sColors;
      set
      {
        this.sColors = value;
        this.OnPropertyChanged();
      }
    }

    private string valueS;
    public string ValueS
    {
      get => this.valueS;
      set
      {
        this.valueS = value;
        this.OnPropertyChanged();
      }
    }

    private int stepperValue;
    public int StepperValue
    {
      get => this.stepperValue;
      set
      {
        this.stepperValue = value;
        this.OnPropertyChanged();
      }
    }

    private bool isCounted;
    public bool IsCounted
    {
      get => this.isCounted;
      set
      {
        this.isCounted = value;
        this.OnPropertyChanged();
      }
    }

    private Color sColor;
    public Color SColor
    {
      get => this.sColor;
      set
      {
        this.sColor = value;
        this.OnPropertyChanged();
      }
    }

    private ColorModel selectedColor;
    public ColorModel SelectedColor
    {
      get => this.selectedColor;
      set
      {
        this.selectedColor = value;
        this.SColor = value.ColorValue;
        this.OnPropertyChanged();
      }
    }
  }
}
