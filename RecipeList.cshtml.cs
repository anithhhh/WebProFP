using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bakery.Pages
{
    public class RecipeListModel : PageModel
    {
        public class Recipe
        {
            public string Name { get; set; }
            public string Ingredients { get; set; }
            public string Instructions { get; set; }
        }

        [BindProperty]
        public string RecipeName { get; set; }

        [BindProperty]
        public string Ingredients { get; set; }

        [BindProperty]
        public string Instructions { get; set; }

        public List<Recipe> Recipes { get; private set; } = new List<Recipe>();

        public void OnGet()
        {
            // Example data (optional)
            Recipes.Add(new Recipe
            {
                Name = "Chocolate Cake",
                Ingredients = "Flour, Sugar, Cocoa, Eggs",
                Instructions = "1. Mix ingredients. 2. Bake at 180°C for 30 minutes."
            });

            Recipes.Add(new Recipe
            {
                Name = "Pancakes",
                Ingredients = "Flour, Milk, Eggs, Butter",
                Instructions = "1. Mix ingredients. 2. Cook on medium heat until golden brown."
            });
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(RecipeName) && !string.IsNullOrEmpty(Ingredients) && !string.IsNullOrEmpty(Instructions))
            {
                Recipes.Add(new Recipe
                {
                    Name = RecipeName,
                    Ingredients = Ingredients,
                    Instructions = Instructions
                });
            }

            return Page();
        }
    }
}
