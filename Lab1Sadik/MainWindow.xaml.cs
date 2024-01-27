using Lab1Sadik;
using Lab1Sadik.Model;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Lab1Ssadik
{
    public partial class MainWindow : Window
    {
        List<CalculationAction> actions = new List<CalculationAction>();

        public MainWindow()
        {
            InitializeComponent();

            actionList.ItemsSource = actions;
        }

        private double Calculate(Calculation calc1, Calculation calc2)
        {
            double result = calc1.Perform(double.Parse(startNumberBox.Text));
            result = calc2.Perform(result);
            return result;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Add addOperation = new Add(double.Parse(inputBox.Text));
                AddItemIfSpace(new CalculationAction($"Увеличение на {inputBox.Text}", addOperation));
                actionList.Items.Refresh();
            }
            catch(FormatException ex)
            {
                SnackbarSeven.MessageQueue?.Enqueue("Не правильный формат числа для действия!", null, null, null, false, true, TimeSpan.FromSeconds(1.5));
            }
            
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Multiply multiplyOperation = new Multiply(double.Parse(inputBox.Text));
                AddItemIfSpace(new CalculationAction($"Умножение на {inputBox.Text}", multiplyOperation));
                actionList.Items.Refresh();

            } catch (FormatException ex)
            {
                SnackbarSeven.MessageQueue?.Enqueue("Не правильный формат числа для действия", null, null, null, false, true, TimeSpan.FromSeconds(1.5));
            }
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(startNumberBox.Text))
                {
                    throw new ArgumentException();
                }

                resultText.Text = $"Результат: {Calculate(actions[0].action, actions[1].action).ToString()}";
            } catch (ArgumentOutOfRangeException ex)
            {
                SnackbarSeven.MessageQueue?.Enqueue("Должно быть 2 действия", null, null, null, false, true, TimeSpan.FromSeconds(1.5));
            }
            catch (ArgumentException ex)
            {
                SnackbarSeven.MessageQueue?.Enqueue("Введите начальное число", null, null, null, false, true, TimeSpan.FromSeconds(1.5));

            }
        }

        private void AddItemIfSpace(CalculationAction calculationAction)
        {
            if (actionList.Items.Count < 2)
            {
                actions.Add(calculationAction);
            } else
            {
                SnackbarSeven.MessageQueue?.Enqueue("Максимум 2 действия может быть", null, null, null, false, true, TimeSpan.FromSeconds(1.5));

            }
        }
    }
}
