using System.Linq;
using agentus.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace agentus.Views;

public partial class AgentCard : Window
{
    public AgentCard()
    {
        InitializeComponent();
        SP.DataContext = AgentList.AgentsList.First();
    }

    public AgentCard(Agents agent)
    {
        InitializeComponent();
        SP.DataContext = agent;
    }
}