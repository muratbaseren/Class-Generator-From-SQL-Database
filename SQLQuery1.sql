select name,dbid from dbo.sysdatabases where dbid>4 

select * from dbo.sysobjects
where xtype='U' and name<>'dtproperties' order by colorder

select * from Customers

select * from dbo.systypes
select * from dbo.syscolumns
where  id=object_id('Customers') 
and xtype=xusertype 

select dbo.syscolumns.name,dbo.systypes.name,dbo.syscolumns.colstat 
from dbo.syscolumns,dbo.systypes
where id=object_id('Customers')
and dbo.systypes.xtype=dbo.syscolumns.xtype
and dbo.systypes.name<>'sysname'
order by colorder


select dbo.syscolumns.name,dbo.systypes.name,dbo.syscolumns.colstat,dbo.syscolumns.isnullable 
from dbo.syscolumns, dbo.systypes 
where id=object_id('Orders')
and dbo.systypes.xtype=dbo.syscolumns.xtype 
and dbo.systypes.name<>'sysname' order by colorder

select * from Orders

