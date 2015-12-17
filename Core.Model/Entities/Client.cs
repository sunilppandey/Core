using Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Model.Entities
{
    public class Client : DomainEntity<int>
    {
        public string Secret { get; set; }
        public string Name { get; set; }
        public Enumerations.ApplicationTypes ApplicationType { get; set; }
        public bool Active { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        public string AllowedOrigin { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(Secret))
            {
                yield return new ValidationResult("Secret can't be None.", new[] { "Secret" });
            }
        }
    }
}
