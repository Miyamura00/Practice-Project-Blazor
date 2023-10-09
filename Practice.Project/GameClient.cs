using Practice.Project.Models;

namespace Practice.Project;

public static class GameClient
{
    private static readonly List<Game> games = new()
{
    new Game(){
    Id = 1,
    Name = "Gran Turismo",
    Genre = "Racing",
    Price = 19.99M,
    ReleaseDate = new DateTime(2020, 2, 1)

        },
    new Game(){
    Id = 2,
    Name = "Final Fantasy XIV",
    Genre = "Role-playing Game",
    Price = 59.99M,
    ReleaseDate = new DateTime(2010, 3, 1)

        },
    new Game(){
    Id = 3,
    Name = "FIFA 23",
    Genre = "Sports",
    Price = 69.99M,
    ReleaseDate = new DateTime(2022, 8, 22)

        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);

    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("Could not find Game!");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }

}