# Registration screen 

 


##### Screen for registration with validation, using Dataannotations in models.

 


## :pushpin: Entities

#### Entities used in the application

~~~c#
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataAtual { get; set; }
        public string  Pais { get; set; }
~~~

## :ballot_box_with_check: Dataannotations

#### Dataannotations components used in the models

~~~c#
[Key]
[Display]
[RegularExpression]
[Required(ErrorMessage)]
[StringLength(MinimumLength)]
[DataType(DataType.DateTime)]
~~~

## :white_check_mark: Models

~~~c#
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo Nome é necessário.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Nome deve conter de 3 à 20 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage ="Caracter inválido.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome é necessário.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Sobrenome deve conter de 3 à 20 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage ="Caracter inválido.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo Data é necessário.")]
        [DataType(DataType.DateTime, ErrorMessage ="Data em formato inválido.")]
        [Display(Name ="Data de Cadastro")]
        public DateTime DataAtual { get; set; }
        
        [Required(ErrorMessage = "O campo País é necessário.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "País deve conter de 3 à 20 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Caracter inválido.")]
        public string  Pais { get; set; }
~~~

## :page_with_curl: View

### :beginner: Model called in view

#### Calling the model in the view to be able to use its own entities
~~~c#

@model FirstWindow.Models.Cadastro

@{ 
    ViewData["Title"] = "Cadastro";
}
~~~

### :beginner: Html

#### Asp-for will be used to call entities in the view to do validations

~~~html
<h1>@ViewData["Title"]</h1>

<div class="row">
    <div class="col-md-4">
    
        //Action return for index in controller
        <form asp-action="Index">
           
            //The Validation Summary Tag Helper is used to display a summary of validation messages
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>

            <div class="form-group">
                <label asp-for="Nome" class="col-form-label"></label>
                <input asp-for="Nome" class="form-control" />
                <span asp-validation-for="Nome" class="text-danger"></span>
            </div>

            <div class="form-group">
                <label asp-for="Sobrenome" class="col-form-label"></label>
                <input asp-for="Sobrenome" class="form-control" />
                <span asp-validation-for="Sobrenome" class="text-danger"></span>
            </div>

            <div class="form-group">
                <label asp-for="DataAtual" class="col-form-label"></label>
                <input asp-for="DataAtual" class="form-control" />
                <span asp-validation-for="DataAtual" class="text-danger"></span>
            </div>

            <div class="form-group">
                <label asp-for="Pais" class="col-form-label"></label>
                <input asp-for="Pais" class="form-control" />
                <span asp-validation-for="Pais" class="text-danger"></span>
            </div>

            <div class="form-group">
                <input type="submit" value="Cadastrar" class="btn btn-primary"/>
            </div>

        </form>

    </div>
</div>
~~~

### :beginner: Validation

#### Validation in Jquery calling the native .net scripts on the front through the method:

~~~c#
@section Scripts{ 
    @{ 
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    }
}
~~~

#### These are the scripts for Jquery in folder shared

~~~javascript
<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>;
<script src="~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"></script>;
~~~

## :wrench: Controller

#### Controller to return the action to the view and validate the data that is returning to the model

~~~c#
public class CadastroController : Controller
    {
        //Method Get
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        //Method Post
        [HttpPost]
        public IActionResult Index(Cadastro cadastro)
        {
            //validation of the values that are returning
            if (ModelState.IsValid)
            {

            }
            return View(cadastro);
        }
    }
~~~
