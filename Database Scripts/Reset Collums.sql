use dmaa0918_1074212

DELETE FROM dbo.OrderLine;
DELETE FROM dbo.Orders;
DELETE FROM dbo.OrderStatus;
DELETE FROM dbo.Payment;
DELETE FROM dbo.ProductFandom;
DELETE FROM dbo.Location;
DELETE FROM dbo.Stock;
DELETE FROM dbo.Product;
DELETE FROM dbo.Supplier;
DELETE FROM dbo.City;
DELETE FROM dbo.Value;
DELETE FROM dbo.Property;
DELETE FROM dbo.ProdPropertyValue;

DBCC CHECKIDENT (OrderStatus, RESEED, 0)
DBCC CHECKIDENT (Payment, RESEED, 0)
DBCC CHECKIDENT (Orders, RESEED, 0)
DBCC CHECKIDENT (Property, RESEED, 0)
DBCC CHECKIDENT (Value, RESEED, 0)
DBCC CHECKIDENT (Product, RESEED, 0)
DBCC CHECKIDENT (ProductFandom, RESEED, 0)
DBCC CHECKIDENT (OrderLine, RESEED, 0)
DBCC CHECKIDENT (Supplier, RESEED, 0)