var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.AspireTest4_ApiService>("apiservice");

builder.AddProject<Projects.AspireTest4_Web>("webfrontend")
	.WithReference(cache)
	.WithReference(apiService);

builder.Build().Run();
