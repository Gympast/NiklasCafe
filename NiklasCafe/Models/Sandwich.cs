namespace NiklasCafe.Models;

public class Sandwich
{
    public List<Ingredient> Ingredients { get; set; } = new ();

    public override string ToString()
    {
        var sandwichDescription = string.Empty;

        sandwichDescription += "The sandwich contains:\n";

        foreach (var drinkIngredient in Ingredients)
        {
            sandwichDescription += $"\t{drinkIngredient.Name}\n";
        }

        return sandwichDescription;
    }
}