
mysql -u root mysql -e "select user, host from user;"

sudo mysql -u root -e "GRANT ALL PRIVILEGES ON rd.* to 'photon'@'31.2.225.160' IDENTIFIED BY 'znf42CYfWhA3st7w';"

mysql -u photon -h 37.32.9.55 -p < database.sql
dotnet ef dbcontext scaffold "server=37.32.9.55;uid=photon;pwd=znf42CYfWhA3st7w;database=rd" MySql.EntityFrameworkCore -o models -f
