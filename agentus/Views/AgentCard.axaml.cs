using System.Linq;
using agentus.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace agentus.Views;

public partial class AgentCard : Window
{
    public AgentCard(Agents selectedAgents)
    {
        InitializeComponent();

        NameTextBlock.Text = "Имя агента: " + selectedAgents.AgentName;
        TypeTextBlock.Text = "Тип агента: " + selectedAgents.AgentType;
        CountSellsTextBlock.Text = "Количество продаж: " + (selectedAgents.AgentDiscount).ToString();
        DiscountTextBlock.Text = "Скидка: " + (selectedAgents.AgentDiscount).ToString();
        PhoneTextBlock.Text = "Номер телефона: " + (selectedAgents.AgentPhone).ToString();
        EmailTextBlock.Text = "Email: " + selectedAgents.AgentEmail;
        AdressTextBlock.Text = "Адрес агента: " + selectedAgents.AgentAdress;
        InnTextBlock.Text = "ИНН агента: " + (selectedAgents.CompanyINN).ToString();
        KppTextBlock.Text = "КПП агента: " + (selectedAgents.CompanyKPP).ToString();
        CeoNameTextBlock.Text = "Имя директора: " + selectedAgents.CeoName;
        CompanyEmailTextBlock.Text = "Email компании: " + selectedAgents.CompanyEmail;
    }

    public AgentCard()
    {
        InitializeComponent();
    }
}