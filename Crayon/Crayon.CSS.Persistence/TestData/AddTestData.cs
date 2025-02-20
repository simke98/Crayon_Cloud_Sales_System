using Crayon.CSS.Domain.Entities;
using Crayon.CSS.Domain.Enums;

namespace Crayon.CSS.Persistence.TestData;

public abstract class AddTestData
{

    public static List<Customer> GetCustomer()
    {
        return new List<Customer>
        {
            new Customer
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Customer1",
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new Customer
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Customer2",
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new Customer
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Customer3",
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            }
        };

    }

    public static List<Account> GetAccounts()
    {
        var customers = GetCustomer();
        return new List<Account>
        {
            new Account
            {
                Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                Name = "Customer1 Primary",
                CustomerId = customers.FirstOrDefault(c => c.Id == Guid.Parse("11111111-1111-1111-1111-111111111111")).Id,
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new Account
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                Name = "Customer1 Secondary",
                CustomerId = customers.FirstOrDefault(c => c.Id == Guid.Parse("11111111-1111-1111-1111-111111111111")).Id,
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new Account
            {
                Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                Name = "Customer2 Main",
                CustomerId = customers.FirstOrDefault(c => c.Id == Guid.Parse("22222222-2222-2222-2222-222222222222")).Id,
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new Account
            {
                Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                Name = "Customer3 Core",
                CustomerId = customers.FirstOrDefault(c => c.Id == Guid.Parse("33333333-3333-3333-3333-333333333333")).Id,
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            }
        };
    }

    public static List<SoftwareLicense> GetSoftwareLicenses()
    {
        var accounts = GetAccounts();

        return new List<SoftwareLicense>
        {
            new SoftwareLicense
            {
                Id = Guid.Parse("bb23fb79-791d-423d-8da2-0543db31778d"),
                AccountId = accounts.FirstOrDefault(a => a.Name == "Customer1 Primary")?.Id ?? Guid.Empty,
                Quantity = 100,
                State = LicensesState.Active,
               ExpirationDate = DateTime.Parse("8-31-2025 12:00:00"),
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new SoftwareLicense
            {
                Id = Guid.Parse("e4b367c8-d8e0-437c-bc7b-089fb1b79fe6"),
                AccountId = accounts.FirstOrDefault(a => a.Name == "Customer1 Secondary")?.Id ?? Guid.Empty,
                Quantity = 200,
                State = LicensesState.Active,
            ExpirationDate = DateTime.Parse("8-31-2025 12:00:00"),
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new SoftwareLicense
            {
                Id = Guid.Parse("94355fb5-45bc-41f1-ae1d-402d2dd4895b"),
                AccountId = accounts.FirstOrDefault(a => a.Name == "Customer2 Main")?.Id ?? Guid.Empty,
                Quantity = 300,
                State = LicensesState.Active,
              ExpirationDate = DateTime.Parse("8-31-2025 12:00:00"),
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            },
            new SoftwareLicense
            {
                Id = Guid.Parse("ee517cfb-5470-4ce5-bdf1-eef88fca7ccb"),
                AccountId = accounts.FirstOrDefault(a => a.Name == "Customer3 Core")?.Id ?? Guid.Empty,
                Quantity = 50,
                State = LicensesState.Active,
                ExpirationDate = DateTime.Parse("8-31-2025 12:00:00"),
                CreatedAt = DateTime.Parse("2025-02-20 10:15:32"),
                UpdatedAt = DateTime.Parse("2025-02-20 10:15:32"),
            }
        };
    }

}
