using agentus.Models;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Fonts;

namespace agentus.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        AgentListBox.ItemsSource = AgentList.AgentsList;
    }

    private void InputElement_OnDoubleTapped(object? sender, TappedEventArgs e)
    {
        Agents selectedAgents = (Agents)(sender as StackPanel)!.Tag!;
        Agents agent = (Agents)(sender as StackPanel)!.Tag!;
        AgentCard agentCard = new AgentCard(selectedAgents);
        agentCard.Show();
        Close();
    }
}