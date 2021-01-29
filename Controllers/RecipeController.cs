using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecipositoryApi.Data;
using RecipositoryApi.Models;

namespace RecipositoryApi.Controllers
{
    [Route("api/recipe")]
    [ApiController]
    public class RecipeController:Controller
    {
        private readonly ILogger<RecipeController> _logger;
        private readonly IRecipositoryApiRepo _repo;

        public RecipeController(ILogger<RecipeController> logger, IRecipositoryApiRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        /// <summary>
        /// Retrieve All recipes.
        /// Route sample: (GET) http://localhost:4200/api/recipe
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetRecipes(){
            return Ok(_repo.GetRecipe());
        }

        /// <summary>
        /// Retrive a recipe by id.
        /// Route sample: (GET) http://localhost:4200/api/recipe/1
        /// </summary>
        /// <param name="id">RecipeId</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult GetRecipeById(int id){
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save specified recipe.
        /// Route sample: (POST) http://localhost:4200/api/recipe
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveRecipe(Recipe recipe){
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a recipe by id.
        /// Route sample: (GET) http://localhost:4200/api/recipe/1
        /// </summary>
        /// <param name="id">RecipeId</param>
        /// <returns></returns>
        [HttpGet("delete/{id}")]
        public ActionResult DeleteRecipeById(int id){
            throw new NotImplementedException();
        }
    }
}