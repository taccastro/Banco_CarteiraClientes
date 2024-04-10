CREATE TABLE Trades (
    TradeID INT PRIMARY KEY,
    Value FLOAT,
    ClientSector VARCHAR(10)
);

INSERT INTO Trades (TradeID, Value, ClientSector) VALUES
(1, 2000000, 'Private'),
(2, 400000, 'Public'),
(3, 500000, 'Public'),
(4, 3000000, 'Public');

CREATE PROCEDURE CategorizeTrades
AS
BEGIN
    CREATE TABLE TradeCategories (
        TradeID INT,
        Category VARCHAR(20)
    );

    INSERT INTO TradeCategories (TradeID, Category)
    SELECT
        TradeID,
        CASE
            WHEN Value < 1000000 AND ClientSector = 'Public' THEN 'LOWRISK'
            WHEN Value >= 1000000 AND ClientSector = 'Public' THEN 'MEDIUMRISK'
            WHEN Value >= 1000000 AND ClientSector = 'Private' THEN 'HIGHRISK'
        END AS Category
    FROM Trades;
END;