using clase4.Models;

namespace clase4.Services;

public static class GameService
{
    public static List<Game> GameList {get; set;} = new List<Game>();

    public static List<Game> GetAll()         //devuelve una lista de juegos.
    {
        if(GameList.Count() == 0)
        {
            var game1 = new Game();
            game1.Name = "Fifa 2023";
            game1.IsMultiPlayer = true;
            game1.Realease = 2022;
            GameList.Add(game1);

            var game2 = new Game();
            game2.Name = "Mortal Kombat";
            game2.IsMultiPlayer = true;
            game2.Realease = 1995;
            GameList.Add(game2);

            var game3 = new Game();
            game3.Name = "Mario Bros";
            game3.IsMultiPlayer = true;
            game3.Realease = 1990;
            GameList.Add(game3);
        }
        return GameList;
    }

    public static void Delete(string name)
    {
        var item = GameList.FirstOrDefault (x => x.Name.ToLower() == name.ToLower());
        if (item != null)
        {
         GameList.Remove(item);
        }
    }
    
    public static void Create(Game newGame)
    {
        GameList.Add(newGame);
    }

    public static void Update()
    {
        
    }
}