use dmaa0918_1074212
-----------property-----------
INSERT INTO Property (propertyName)
VALUES ('T-shirt size'); 

INSERT INTO Property (propertyName)
VALUES ('Width'); 

INSERT INTO Property (propertyName)
VALUES ('Length');

INSERT INTO Property (propertyName)
VALUES ('color'); 

INSERT INTO Property (propertyName)
VALUES (' '); 

-----------Value-----------
INSERT INTO Value (attributes, propertyID)
VALUES ('small', 1); 

INSERT INTO Value (attributes, propertyID)
VALUES ('medium', 1); 

INSERT INTO Value (attributes, propertyID)
VALUES ('Large', 1); 

INSERT INTO Value (attributes, propertyID)
VALUES ('18', 2); 

INSERT INTO Value (attributes, propertyID)
VALUES ('24', 3); 

INSERT INTO Value (attributes, propertyID)
VALUES ('24', 2); 

INSERT INTO Value (attributes, propertyID)
VALUES ('36', 3); 

INSERT INTO Value (attributes, propertyID)
VALUES ('blue', 4); 

INSERT INTO Value (attributes, propertyID)
VALUES ('black', 4);

INSERT INTO Value (attributes, propertyID)
VALUES ('red', 4);  

INSERT INTO Value (attributes, propertyID)
VALUES (' ', 5);

-----------City-----------
INSERT INTO City (zipcode, city)
VALUES (9000, 'Aalborg');

-----------Supplier-----------
INSERT INTO Supplier(supplierName, phone, email, zipcode)
VALUES('Tshirtshop',20203030,'tshirtshop@gmail.com',9000);

INSERT INTO Supplier(supplierName, phone, email, zipcode)
VALUES('jørgen & co',10010010, 'jørgen@hotmail.dk',9000);

INSERT INTO Supplier(supplierName, phone, email, zipcode)
VALUES('pepe',20203030,'jjt@pepe.dk',9000)

-----------Product-----------

INSERT INTO Product(price, productname, productDescription, supplierID, quantity, visible)
VALUES(500,  'Lord of the rings Frodo poster', 'a poster of Frodo holding the ring', 3, 20, 1);

INSERT INTO Product(price, productname, productDescription, supplierID, quantity, visible)
VALUES(25000, 'Lord of the rings original ring', 'The original ring used in during the filming of lord of the rings', 2, 1, 0);

INSERT INTO Product(price, productname, productDescription, supplierID, quantity, visible)
VALUES(500,  'J.cole T-shirt', 'picture of J.cole performing at a koncert', 1, 15, 1);

-----------Stock-----------
INSERT INTO Stock (arrivalDate, supplierId,inOrder,productID)
VALUES (2019-1-12,3, 20 , 1);

INSERT INTO Stock (arrivalDate, supplierId, inOrder, productID)
VALUES (2019-1-12, 2, 2 , 2);

INSERT INTO Stock (arrivalDate, supplierId,inOrder,productID)
VALUES (2019-1-12, 1, 20 , 3);

INSERT INTO Stock (arrivalDate, supplierId,inOrder,productID)
VALUES (2019-1-12, 3, 20 , 3);

-----------Location-----------
INSERT INTO Location (productID, LocationNO)
VALUES (1,'016425');
INSERT INTO Location (productID, LocationNO)
VALUES (2,'015230');
INSERT INTO Location (productID, LocationNO)
VALUES (1,'001200');

-----------ProductFandom-----------
INSERT INTO ProductFandom(fandomName, productID)
VALUES ('Lord of the rings', 1);

INSERT INTO ProductFandom(fandomName, productID)
VALUES ('Lord of the rings', 2);

INSERT INTO ProductFandom(fandomName, productID)
VALUES ('Hiphop', 3);

-----------Payment-----------
INSERT INTO Payment ( paymentDate, totalAmount)
VALUES ( 2019-12-12, 5000); 

INSERT INTO Payment ( paymentDate, totalAmount)
VALUES ( 2019-23-12, 250); 

INSERT INTO Payment ( paymentDate, totalAmount)
VALUES ( 2019-29-10, 750);  


-----------OrderStatus-----------
INSERT INTO OrderStatus ( status)
VALUES ('pending'); 

INSERT INTO OrderStatus ( status)
VALUES ('declined');

INSERT INTO OrderStatus ( status)
VALUES ('open');

INSERT INTO OrderStatus ( status)
VALUES ('closed'); 

-----------Orders-----------
INSERT INTO Orders ( invoiceDate, invoiceDueDate, paymentID, orderStatusID)
VALUES ( 2019-2-12, 2019-12-12, 1, 4); 

INSERT INTO Orders ( invoiceDate, invoiceDueDate, paymentID, orderStatusID)
VALUES ( 2019-2-13, 2019-12-23, 2, 3); 

INSERT INTO Orders ( invoiceDate, invoiceDueDate, paymentID, orderStatusID)
VALUES ( 2019-2-12, 2019-12-12, 3, 1); 

-----------OderLine-----------
INSERT INTO OrderLine(orderId, amount, price, lineText, productID)
VALUES(1, 2, 1000, null , 1);

INSERT INTO OrderLine(orderId, amount, price, lineText, productID)
VALUES(1, 5, 2500, null , 3);

INSERT INTO OrderLine(orderId, amount, price, lineText, productID)
VALUES(2, 1, 25000, null , 1);

INSERT INTO OrderLine(orderId, amount, price, lineText, productID)
VALUES(3, 1, 500, null , 1);

-----------ProdProppertyValue-----------
INSERT INTO ProdPropertyValue(productID,valueID)
Values(1,4);

INSERT INTO ProdPropertyValue(productID,valueID)
Values(1,5);

INSERT INTO ProdPropertyValue(productID,valueID)
Values(1,6);

INSERT INTO ProdPropertyValue(productID,valueID)
Values(1,7);

INSERT INTO ProdPropertyValue(productID,valueID)
Values(2,11);

INSERT INTO ProdPropertyValue(productID,valueID)
Values(3,1);

INSERT INTO ProdPropertyValue(productID,valueID)
Values(3,2);

INSERT INTO ProdPropertyValue(productID,valueID)
Values(3,3);