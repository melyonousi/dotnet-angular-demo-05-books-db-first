	dotnet ef dbcontext scaffold "Host=localhost;Database=dotnet-angular-demo-05;Username=postgres;Password=pass123456789" Npgsql.EntityFrameworkCore.PostgreSQL -o Models
	
	dotnet run --launch-profile https
	https://localhost:7179/swagger/index.html