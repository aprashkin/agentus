using agentus.Models;
using Avalonia.Controls;

namespace agentus.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        AgentListBox.ItemsSource = AgentList.AgentsList;
    }
}