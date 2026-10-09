var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebApplication_Security_TestApi>("webapplication-security-testapi");

builder.Build().Run();
