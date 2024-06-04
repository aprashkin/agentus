using System.Collections.Generic;
using Avalonia.Media.Imaging;

namespace agentus.Models;

public class Agents
{
    public string AgentName { get; set; }
    public string AgentType { get; set; }
    public int AgentCountSells { get; set; }
    public int AgentDiscount { get; set; }
    public int AgentPhone { get; set; }
    public string AgentEmail { get; set; }
    public Bitmap AgentImagePath { get; set; }
    public Bitmap CompanyLogo { get; set; }
    public string AgentAdress { get; set; }
    public int CompanyINN { get; set; }
    public int CompanyKPP { get; set; }
    public string CeoName { get; set; }
    public string CompanyEmail { get; set; }
}

public static class AgentList
{
    public static List<Agents> AgentsList = new List<Agents>()
    {
        new Agents
        {
            AgentName = "IVAN", AgentType = "House", AgentAdress = "341 BROOKLYN STREET", AgentDiscount = 3,
            AgentEmail = "ivanbrooklyn@mail.com", AgentPhone = 89765587, AgentImagePath = new Bitmap("C:\\Users\\PROFI\\RiderProjects\\agentus\\agentus\\Assets\\AgentsIcon\\agent_1.png"), CeoName = "VIKTOR",
            CompanyEmail = "ceobrooklyn@gmail.com", CompanyLogo = new Bitmap("C:\\Users\\PROFI\\RiderProjects\\agentus\\agentus\\Assets\\AgentsIcon\\agent_1.png"), CompanyINN = 25523, CompanyKPP = 26356,
            AgentCountSells = 10
        },
        new Agents
        {
        AgentName = "IVAN", AgentType = "House", AgentAdress = "341 BROOKLYN STREET", AgentDiscount = 3,
        AgentEmail = "ivanbrooklyn@mail.com", AgentPhone = 89765587, AgentImagePath = new Bitmap("C:\\Users\\PROFI\\RiderProjects\\agentus\\agentus\\Assets\\AgentsIcon\\agent_43.png"), CeoName = "VIKTOR",
        CompanyEmail = "ceobrooklyn@gmail.com", CompanyLogo = new Bitmap("C:\\Users\\PROFI\\RiderProjects\\agentus\\agentus\\Assets\\AgentsIcon\\agent_53.png"), CompanyINN = 25523, CompanyKPP = 26356,
        AgentCountSells = 10
    }
    };
}