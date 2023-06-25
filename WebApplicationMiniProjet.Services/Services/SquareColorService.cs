using WebApplicationMiniProjet.Entities.Constants;

namespace WebApplicationMiniProjet.Services.Services;

public class SquareColorService : ISquareColorService
{
    public List<string> CalculateSquareColors()
    {
        var squares = new List<string>();
        for (int i = 1; i <= 50; i++)
        {
            string squareColor = i switch
            {
                var x when x % 3 == 0 && x % 5 == 0 => SquareColors.Yellow,
                var x when x % 3 == 0 => SquareColors.Green,
                var x when x % 5 == 0 => SquareColors.Blue,
                _ => ""
            };
            squares.Add(squareColor);
        }
        return squares;
    }
}
