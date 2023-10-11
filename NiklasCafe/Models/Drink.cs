﻿namespace NiklasCafe.Models;

public class Drink
{
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public override string ToString()
    {
        var drinkDescription = "";
        drinkDescription += "The drink contains:\n";

        Ingredients.ForEach(i => drinkDescription += $"\t{i.Name}\n");
        //foreach (var drinkIngredient in Ingredients)
        //{
        //    drinkDescription += $"\t{drinkIngredient.Name}\n";
        //}

        return drinkDescription;
    }
}