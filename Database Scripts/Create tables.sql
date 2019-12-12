use dmaa0918_1074212

create table City(
zipCode int NOT NULL PRIMARY KEY,
city varchar(50)
);

create table Property(
propertyID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
propertyName varchar(50)
);

create table Value(
valueID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
attributes varchar(50),
propertyID int,
FOREIGN KEY(propertyID) REFERENCES Property(propertyID)
);

create table Supplier(
supplierID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
supplierName varchar(75),  
supplierAddress varchar(50),
phone bit,
email varchar(50),
zipcode int,
FOREIGN KEY(zipcode) REFERENCES City(zipcode)
);

Create table Payment(
paymentID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
paymentDate datetime,
totalAmount int NOT NULL
);

Create table OrderStatus(
orderStatusID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
status varchar(50)
);

create table Product(
productID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
price float NOT NULL, 
productName varchar(75),  
productDescription varchar(500), 
supplierID int,
FOREIGN KEY(supplierID) REFERENCES Supplier(supplierID),
quantity int,
);

create table CartItem(
cartItemID int not null IDENTITY(1,1) PRIMARY KEY,
sessionID varchar(100) not null,
quantity int,
createdDate datetime,
productID INT,
FOREIGN KEY(productID) REFERENCES Product(productID)
);


create table Images(
imageID int NOT NULL IDENTITY (1,1) PRIMARY KEY,
imageName varchar(50),
imagePath varchar(50),
productID int NOT NULL,
FOREIGN KEY (productID) REFERENCES Product(productID)
);

create table Location(
productID int NOT NULL,
locationNo varchar(6) NOT NULL,
FOREIGN KEY (productID) REFERENCES Product(productID),
PRIMARY KEY  (productID, locationNo)
);

create table ProductFandom(
PFandomID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
fandomName varchar(50),  
productID int,
FOREIGN KEY(productID) REFERENCES Product(productID)
);

create table Stock(
stockID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
arrivalDate datetime,  
inOrder int,
supplierID int,
productID int,
FOREIGN KEY(supplierID) REFERENCES Supplier(supplierID),
FOREIGN KEY(productID) REFERENCES Product(productID)
);
 

create table ProdPropertyValue(
valueID int, FOREIGN KEY(valueID) REFERENCES value(valueID),
productID int, 
FOREIGN KEY(productID) REFERENCES Product(productID),
PRIMARY KEY (valueID, productID)
);
 
 
Create table Orders(
orderID int NOT NULL IDENTITY(1,1)  PRIMARY KEY,
invoiceDate datetime,
invoiceDueDate datetime,
paymentID int,
FOREIGN KEY(paymentID) REFERENCES Payment(paymentID),
orderStatusID int,
FOREIGN KEY(orderStatusID) REFERENCES OrderStatus(orderStatusID),
);
 
Create table OrderLine(
orderLineID int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
amount int NOT NULL,
price float NOT NULL,
lineText varchar(100),
productID int, 
orderID int,
FOREIGN KEY  (orderID) REFERENCES Orders (orderID),
FOREIGN KEY(productID) REFERENCES Product(productID)
);
 

 

