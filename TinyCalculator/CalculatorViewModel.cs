using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TinyCalculator
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        // Constructor
        public CalculatorViewModel()
        {
            _calculateCommand = new DelegateCommand(() =>
            {
                Calculator calculator = new Calculator();
                Result = calculator.Calculate(Input);
            });
        }

        // Input property
        public string Input { get; set; }

        // Command for calculation
        ICommand _calculateCommand;
        public ICommand CalculateCommand
        {
            get { return _calculateCommand; }
        }

        // Result property
        int _result;
        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Result"));
                }
            }
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
