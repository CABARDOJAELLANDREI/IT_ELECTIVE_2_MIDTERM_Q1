using System.ComponentModel.DataAnnotations;

namespace IT_ELECTIVE_BSIT312E_Cabardo_JaellAndrei.Models
{
    public class LoginViewModel // ViewModel ang nagsisilbing container ng data na ini-input ng user sa login form. Dito natin ini-store ang Username at Password.
    {
        // It has two properties: Username and Password.
        // I used Data Annotations for validation.
        // The Required attribute ensures that the user cannot leave the field empty.
        [Required(ErrorMessage = "Username is required.")] // Required attribute. This line means, hindi puwedeng iwanang blank ang Username. Kapag walang inilagay ang user, lalabas ang message na 'Username is required.
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")] // This line means, kailangan ang username ay may minimum na 3 to 50 characters.
        public string Username { get; set; } // Ito naman ang property na magho-hold ng username na in-enter ng user.

        [Required(ErrorMessage = "Password is required.")] // Same concept lang po ito sa Username. Required din ang Password kaya hindi puwedeng walang laman.
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")] // This line means, kailangan ang password ay may minimum na 6 characters.
        public string Password { get; set; } // Ito naman ang property na magse-save ng password na inilagay ng user.
    }
}

//These validation rules are automatically checked when the form is submitted.

// Good day everyone. My name is Jaell Andrei Cabardo from BSIT31E2.
//In this video, I will demonstrate my ASP.NET Core MVC Model Binding project. The project is a simple 
//login page that uses Model Binding, Data Annotations, ModelState validation, and controller actions.
//This project does not use a database because the login credentials are hard-coded as required in the assignment.