using System;

namespace Lab1_3.Models
{
    public class PlayerData
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Nickname { get; set; }
        public int Level { get; set; }
        public string Clan { get; set; }
        public string Country { get; set; }

        public BaseModelValidationResult Validate()
        {
            var validationResult = new BaseModelValidationResult();

            if (string.IsNullOrWhiteSpace(Nickname)) validationResult.Append($"Nickname cannot be empty");
            if (Level < 0 || Level > 500) validationResult.Append($"Invalid level. Level {Level} is out of range (0..500)");
            if (string.IsNullOrWhiteSpace(Clan)) validationResult.Append($"Clan cannot be empty");
            if (string.IsNullOrWhiteSpace(Country)) validationResult.Append($"Coutry cannot be empty");
            
            return validationResult;
        }
    }
}