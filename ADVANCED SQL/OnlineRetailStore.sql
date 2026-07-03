CREATE DATABASE OnlineRetailStore;

USE OnlineRetailStore;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
INSERT INTO Products (ProductID, ProductName, Category, Price)
VALUES
(1, 'Laptop A', 'Electronics', 80000),
(2, 'Laptop B', 'Electronics', 95000),
(3, 'Laptop C', 'Electronics', 95000),
(4, 'Phone A', 'Electronics', 45000),
(5, 'Chair A', 'Furniture', 7000),
(6, 'Chair B', 'Furniture', 9000),
(7, 'Table A', 'Furniture', 12000),
(8, 'Table B', 'Furniture', 12000),
(9, 'Sofa', 'Furniture', 25000),
(10, 'Mixer', 'Appliances', 4000),
(11, 'Refrigerator', 'Appliances', 35000),
(12, 'Washing Machine', 'Appliances', 28000);
SELECT * FROM Products;