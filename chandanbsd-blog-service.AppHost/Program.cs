var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.chandanbsd_blog_service>("chandanbsd-blog-service");

builder.Build().Run();
