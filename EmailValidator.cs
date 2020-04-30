using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4RPPOON
{
    class EmailValidator : IEmailValidatorService
    { 
        public int MinLength { get; private set; }
        public EmailValidator(int minLength)
        {
            this.MinLength = minLength;
        }
        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return EndsCorrectly(candidate) && Contains_at_sign(candidate) && IsLongEnough(candidate);
        }
        private bool IsLongEnough(String candidate)
        {
            return candidate.Length >= this.MinLength;
        }
        private bool EndsCorrectly(String candidate)
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }
        private bool Contains_at_sign(string candidate)
        {
            return candidate.Contains("@");
        }
    }
}
