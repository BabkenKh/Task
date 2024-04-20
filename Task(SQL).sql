CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(100)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100)
);

CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);


SELECT p.ProductName, ISNULL(c.CategoryName, 'No Category') AS CategoryName
FROM Products p
LEFT JOIN ProductCategory pc ON pc.ProductID = p.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID
