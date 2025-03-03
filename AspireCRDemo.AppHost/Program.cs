var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireCRDemo_ApiService>("apiservice");

builder.AddProject<Projects.AspireCRDemo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
