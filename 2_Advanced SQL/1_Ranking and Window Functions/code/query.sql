CREATE TABLE Products (
    ProductID INT,
    ProductName NVARCHAR(50),
    Category NVARCHAR(50),
    Price INT
);

INSERT INTO Products VALUES
(1, 'Laptop', 'Electronics', 70000),
(2, 'Phone', 'Electronics', 50000),
(3, 'Tablet', 'Electronics', 50000),
(4, 'TV', 'Electronics', 45000),
(5, 'Jeans', 'Fashion', 2000),
(6, 'Shirt', 'Fashion', 1500),
(7, 'Jacket', 'Fashion', 2000),
(8, 'Shoes', 'Fashion', 1800);

-- ROW_NUMBER()
SELECT 
FROM (
    SELECT ,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS RowNumberResult
WHERE RowNum = 3;

-- Use RANK() 
SELECT 
FROM (
    SELECT ,
           RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
) AS RankResult
WHERE RankNum = 3; 

-- DENSE_RANK()
SELECT 
FROM (
    SELECT ,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Products
) AS DenseRankResult
WHERE DenseRankNum = 3; 
