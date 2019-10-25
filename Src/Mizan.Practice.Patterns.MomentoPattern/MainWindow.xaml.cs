using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mizan.Practice.Patterns.MomentoPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<IMomento> statesStack = new Stack<IMomento>();
        public MainWindow()
        {
            InitializeComponent();
            StoreStroke();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Undo, OnExecutedCommands));
            InkCanvas1.MouseUp += InkCanvas1_MouseUp;
        }

        private void InkCanvas1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StoreStroke();
        }

        private void StoreStroke()
        {
            var momento = InkCanvas1.CreateMomento();
            statesStack.Push(momento);
        }

        private void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
        {
            var mainwindow = (MainWindow)sender;

            if (e.Command == ApplicationCommands.Undo)
            {
                mainwindow.Undo();
            };

        }

        private void Undo()
        {
            if (statesStack.Count > 1)
            {
                statesStack.Pop();
                var lastState = statesStack.Peek();
                this.InkCanvas1.SetMomento(lastState);
            }
        }
    }
}
