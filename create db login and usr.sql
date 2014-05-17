USE [master]
GO
CREATE LOGIN [inventario] WITH PASSWORD=N'invent4rio-', DEFAULT_DATABASE=[inventario], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [inventario]
GO
CREATE USER [inventario] FOR LOGIN [inventario]
GO
USE [inventario]
GO
ALTER USER [inventario] WITH DEFAULT_SCHEMA=[db_owner]
GO
USE [inventario]
GO
ALTER ROLE [db_owner] ADD MEMBER [inventario]
GO
