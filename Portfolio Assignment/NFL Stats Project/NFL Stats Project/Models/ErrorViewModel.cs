using System.ComponentModel.DataAnnotations;

namespace NFLStats.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public int Age { get; set; }

        // Add more properties as needed

        // Example of a calculated property based on other properties
        public string FullName
