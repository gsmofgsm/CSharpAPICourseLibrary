using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(
        ErrorMessage = "Title must be different from description.")]
    public abstract class CourseForManipulationDto // using the abstract modifier in a class declaration indicates that a class is intended only to be base class of other classes
    {
        [Required(ErrorMessage = "You should fill out a title")]
        [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 characters.")]
        public string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "The description shouldn't have more than 1500 characters.")]
        public virtual string Description { get; set; } // modifier abstract state that the description member must be implemented by classes that derived from the abstract class
        // virtual properties are greate when you have an implementation in the base class, but do want to allow overriding.
    }
}
