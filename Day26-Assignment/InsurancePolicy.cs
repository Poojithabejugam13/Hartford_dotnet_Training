using System;
namespace InsuranceLibrary.Models
{
    public class InsurancePolicy
    {
        public int PolicyId { get; set; }
        public string PolicyHolderName { get; set; }
        public string PolicyType { get; set; }   
        public decimal PremiumAmount { get; set; }
        public int PolicyTerm { get; set; }       
        public bool IsActive { get; set; }
        public InsurancePolicy() { }
        public InsurancePolicy(int id, string name, string type,
                               decimal premium, int term)
        {
            PolicyId = id;
            PolicyHolderName = name;
            PolicyType = type;
            PremiumAmount = premium;
            PolicyTerm = term;
            IsActive = true;
        }
        public override string ToString()
        {
            return $"{PolicyId,-5} {PolicyHolderName,-15} {PolicyType,-10} " +
                   $"{PremiumAmount,-10} {PolicyTerm,-5} {IsActive}";
        }
    }
}
