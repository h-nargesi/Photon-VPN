mysql -u photon -h 37.32.9.55 -p < database.sql
dotnet ef dbcontext scaffold "server=37.32.9.55;uid=photon;pwd=znf42CYfWhA3st7w;database=rd" MySql.EntityFrameworkCore -o models -f