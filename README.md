# Crayon Cloud Sales System
Cloud Sales System Technical Exercise

# Cmmands
  - **run** => dotnet run --project Crayon.CSS.Api
  - **build** => dotnet build
# Migrations
  - **creata** =>  dotnet ef migrations add [MigrationName] --startup-project Crayon.CSS.Api --project Crayon.CSS.Persistence -v
  - **update** => dotnet ef database update --startup-project Crayon.CSS.Api --project Crayon.CSS.Persistence -v
  - **remove** =>  dotnet ef migrations remove --startup-project Crayon.CSS.Api --project Crayon.CSS.Persistence -v


# List of API
Swagger
![image](https://github.com/user-attachments/assets/02e106fe-d2d5-4026-9079-d978247dc846)

# How to test
  - see the list of its own accounts
    - **http://localhost:24210/api/v1/Customers/[customerId]/accounts**
      - Test => (GET) http://localhost:24210/api/v1/Customers/11111111-1111-1111-1111-111111111111/accounts
  - see the list of software services available on CCP (you can mock HTTP calls to CCP and return hardcoded list of services)
    - **http://localhost:24210/api/v1/SoftwareService**
  - order software license through CCP (you can mock HTTP calls to CCP and return hardcoded list of services) for specific account
    - **http://localhost:24210/api/v1/SoftwareLicense/[accountId]/order**
      - Test => (POST) http://localhost:24210/api/v1/SoftwareLicense/AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA/order
      <br> Body: ```{ "softwareName": "Microsoft Visual Studio", "quantity": 5, "expirationDate": "2025-09-30T15:20:08.143" }```
  - see purchased software licenses for each account
    - **http://localhost:24210/api/v1/Customers/[customerId]/accounts**
       - Test => (GET) http://localhost:24210/api/v1/Customers/11111111-1111-1111-1111-111111111111/accounts
  - change quantity of service licenses per subscription
    - **http://localhost:24210/api/v1/Accounts/[accounId]/software-licenses/[softwareLicensesId]/quantity**
      - Test => (PUT) http://localhost:24210/api/v1/Accounts/AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA/software-licenses/bb23fb79-791d-423d-8da2-0543db31778d/quantity
         <br> Body: ```{ "quantity": 5 }```
  - cancel the specific software under any account
    - **http://localhost:24210/api/v1/Accounts/[accounId]/software-licenses/[softwareLicensesId]/cancel**
      -  Test => (DELETE) http://localhost:24210/api/v1/Accounts/AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA/software-licenses/bb23fb79-791d-423d-8da2-0543db31778d/cancel
  - extend the software license valid to date (e.g. 31st August -> 30th September
    - **http://localhost:24210/api/v1/SoftwareLicense/[softwareLicensesId]**
      -  Test => (PUT) http://localhost:24210/api/v1/SoftwareLicense/94355FB5-45BC-41F1-AE1D-402D2DD4895B =>
     <br> Body: ```{ "expirationDate": "2025-09-30T15:20:08.143}```
