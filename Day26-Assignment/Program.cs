using System;
using InsuranceLibrary.Models;
using InsuranceLibrary.Services;
class Program
{
    static PolicyService service = new PolicyService();
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Insurance Menu ---");
            Console.WriteLine("1. Add Policy");
            Console.WriteLine("2. View Policies");
            Console.WriteLine("3. Search Policy");
            Console.WriteLine("4. Update Policy");
            Console.WriteLine("5. Deactivate Policy");
            Console.WriteLine("0. Exit");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1: AddPolicy(); break;
                case 2: ViewPolicies(); break;
                case 3: SearchPolicy(); break;
                case 4: UpdatePolicy(); break;
                case 5: DeactivatePolicy(); break;
            }

        } while (choice != 0);
    }
    static void AddPolicy()
    {
        Console.Write("Policy ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID");
            return;
        }
        Console.Write("Holder Name: ");
        string name = Console.ReadLine();
        Console.Write("Policy Type: ");
        string type = Console.ReadLine();
        Console.Write("Premium: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal premium))
        {
            Console.WriteLine("Invalid premium");
            return;
        }
        Console.Write("Term: ");
        if (!int.TryParse(Console.ReadLine(), out int term))
        {
            Console.WriteLine("Invalid term");
            return;
        }
        InsurancePolicy p = new InsurancePolicy(id, name, type, premium, term);
        Console.WriteLine(
            service.AddPolicy(p)
            ? "Policy Added"
            : "Duplicate ID / Limit Reached"
        );
    }
    static void ViewPolicies()
    {
        Console.WriteLine("\nID    Name            Type       Premium    Term  Active");
        foreach (var p in service.GetAllPolicies())
        {
            if (p != null)
                Console.WriteLine(p);
        }
    }
    static void SearchPolicy()
    {
        Console.Write("Enter ID: ");
        int.TryParse(Console.ReadLine(), out int id);
        InsurancePolicy p = service.GetPolicyById(id);
        Console.WriteLine(p != null ? p.ToString() : "Not Found");
    }

    static void UpdatePolicy()
    {
        Console.Write("ID: ");
        int.TryParse(Console.ReadLine(), out int id);
        Console.Write("New Premium: ");
        decimal.TryParse(Console.ReadLine(), out decimal premium);
        Console.Write("New Term: ");
        int.TryParse(Console.ReadLine(), out int term);
        Console.WriteLine(service.UpdatePolicy(id, premium, term)?"Updated":"Not Found");
    }

    static void DeactivatePolicy()
    {
        Console.Write("ID: ");
        int.TryParse(Console.ReadLine(), out int id);
        Console.WriteLine(service.DeactivatePolicy(id)? "Policy Deactivated": "Not Found");
    }
}
