using System.Runtime.ConstrainedExecution;

namespace clase4.Models;

public class GameListViewModel
{
    public string Name {get; set;}
    public int Realease {get; set;}
    public int Age => DateTime.Now.Year - Realease;
}