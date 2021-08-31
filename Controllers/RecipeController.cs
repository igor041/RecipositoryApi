using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using recipositoryApi.Controllers.Shared;
using RecipositoryApi.Data;
using RecipositoryApi.Models;

namespace RecipositoryApi.Controllers
{
    [Route("api/recipe")]
    [ApiController]
    public class RecipeController : BaseController
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
        public async Task<IActionResult> GetRecipesAsync() {

            var recipes = await _repo.GetRecipeAsync();

            if (recipes.Any())
            {
                return Ok(_repo.GetRecipe());
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Retrive a recipe by id.
        /// Route sample: (GET) http://localhost:4200/api/recipe/1
        /// </summary>
        /// <param name="id">RecipeId</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult GetRecipeById(int? id) {
            return Ok(_repo.GetRecipe(id));
        }

        /// <summary>
        /// Save specified recipe.
        /// Route sample: (POST) http://localhost:4200/api/recipe
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveRecipe(Recipe recipe) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a recipe by id.
        /// Route sample: (GET) http://localhost:4200/api/recipe/1
        /// </summary>
        /// <param name="id">RecipeId</param>
        /// <returns></returns>
        [HttpGet("delete/{id}")]
        public ActionResult DeleteRecipeById(int id) {
            throw new NotImplementedException();
        }

        [HttpGet("throwError")]
        public override ActionResult ThrowError(int id)
        {
            return base.ThrowError(id);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Object obj = new Object();
            // Do something before the action executes.
            //Debug.Write(MethodBase.GetCurrentMethod(), "HERE1:" + Utf8Json.JsonSerializer.ToJsonString(context.HttpContext.Request.Headers));
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
            //Debug.Write(MethodBase.GetCurrentMethod(), "HERE2:" + Utf8Json.JsonSerializer.ToJsonString(context));

            base.OnActionExecuted(context);
        }

        // TODO: Chek out this code style
        //[HttpGet("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public IActionResult GetById(int id)
        //{
        //    if (!_repository.TryGetProduct(id, out var product))
        //    {
        //        return NotFound();
        //    }

        //    return Ok(product);
        //}
    }
}