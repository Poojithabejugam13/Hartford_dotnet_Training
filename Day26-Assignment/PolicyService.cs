using InsuranceLibrary.Models;
namespace InsuranceLibrary.Services
{
    public class PolicyService
    {
        private InsurancePolicy[] policies;
        private int count;
        private const int MAX = 5;
        public PolicyService()
        {
            policies = new InsurancePolicy[MAX];
            count = 0;
            AddPolicy(new InsurancePolicy(1, "Ravi", "Health", 5000, 10));
            AddPolicy(new InsurancePolicy(2, "Anu", "Life", 8000, 15));
        }
        public bool AddPolicy(InsurancePolicy policy)
        {
            if (count == MAX)
                return false;
            for (int i = 0; i < count; i++)
            {
                if (policies[i].PolicyId == policy.PolicyId)
                    return false;
            }
            policies[count++] = policy;
            return true;
        }
        public InsurancePolicy[] GetAllPolicies()
        {
            return policies;
        }
        public InsurancePolicy GetPolicyById(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (policies[i].PolicyId == id)
                    return policies[i];
            }
            return null;
        }
        public bool UpdatePolicy(int id, decimal premium, int term)
        {
            InsurancePolicy p = GetPolicyById(id);
            if (p == null) return false;
            p.PremiumAmount = premium;
            p.PolicyTerm = term;
            return true;
        }
        public bool DeactivatePolicy(int id)
        {
            InsurancePolicy p = GetPolicyById(id);
            if (p == null) return false;
            p.IsActive = false;
            return true;
        }
    }
}
