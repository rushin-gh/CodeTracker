--create database CodeTracker;

--use CodeTracker;

--create table CTUser (
--	UserId int identity(1, 1) primary key,
--	UserName varchar(50) not null unique,
--	UserPassword varchar(50) not null
--)

--insert into CTUser values
--('rushi-dev', 'pass');

--select * from CTUser;

--select
--    'data source=' + @@servername +
--    ';initial catalog=' + db_name() +
--    case type_desc
--        when 'WINDOWS_LOGIN' 
--            then ';trusted_connection=true'
--        else
--            ';user id=' + suser_name() + ';password=<<YourPassword>>'
--    end
--    as ConnectionString
--from sys.server_principals
--where name = suser_name()

-- create or alter procedure GetUser
--	@username varchar(50),
--	@password varchar(50)
--as
--begin
--	select * from CTUser
--	where UserName = @username
--	and UserPassword = @password
--end

--exec GetUser 'rushi-dev', 'dev'

--update CTUser set UserPassword = 'dev' where UserId = 1;



