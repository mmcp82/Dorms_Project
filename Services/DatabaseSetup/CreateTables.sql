-- Switch to the MyAppDB database context
-- (All subsequent commands will apply to this database)
USE [Dorms_Project_SQL]

/*
 * Check if a table named 'Users' already exists in the database
 * This prevents errors if we try to create a table that already exists
 * sys.tables is a system view that contains all tables in the current database
 */
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DormsTable')
-- If the table doesn't exist, create it with the following structure:
CREATE TABLE DormsTable (
    -- Identity column that auto-increments (1,1 means starts at 1, increments by 1)
    -- PRIMARY KEY enforces uniqueness and creates a clustered index by default
    DormID INT PRIMARY KEY IDENTITY(1,1),
    DormName NVARCHAR(MAX) NOT NULL,    
    DormCapacity INT NOT NULL,
    DormManagerID INT NOT NULL,
    DormManagerName NVARCHAR(MAX) NOT NULL,
    DormAddress NVARCHAR(MAX)
)







-- Switch to the MyAppDB database context
-- (All subsequent commands will apply to this database)
USE [Dorms_Project_SQL]

/*
 * Check if a table named 'Users' already exists in the database
 * This prevents errors if we try to create a table that already exists
 * sys.tables is a system view that contains all tables in the current database
 */
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DormManagerTable')
-- If the table doesn't exist, create it with the following structure:
CREATE TABLE DormManagerTable (
    -- Identity column that auto-increments (1,1 means starts at 1, increments by 1)
    -- PRIMARY KEY enforces uniqueness and creates a clustered index by default
    DormManagerID INT PRIMARY KEY IDENTITY(1,1),
    DormManagerFirstName NVARCHAR(MAX) NOT NULL,
    DormManagerLastName NVARCHAR(MAX) NOT NULL,
    DormManagerJob NVARCHAR(MAX) NOT NULL,
    DormManagerNationalCode NCHAR(10) NOT NULL,
    DormManagerPhoneNumber NCHAR(10) NOT NULL,
    ManagingDormID INT NOT NULL,
    ManagingDormName NVARCHAR(MAX),
    DormManagerAddress NVARCHAR(MAX)
)







-- Switch to the MyAppDB database context
-- (All subsequent commands will apply to this database)
USE [Dorms_Project_SQL]

/*
 * Check if a table named 'Users' already exists in the database
 * This prevents errors if we try to create a table that already exists
 * sys.tables is a system view that contains all tables in the current database
 */
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CollegianTable')
-- If the table doesn't exist, create it with the following structure:
CREATE TABLE CollegianTable (
    -- Identity column that auto-increments (1,1 means starts at 1, increments by 1)
    -- PRIMARY KEY enforces uniqueness and creates a clustered index by default
    CollegianID INT PRIMARY KEY IDENTITY(1,1),
    CollegianFirstName NVARCHAR(MAX) NOT NULL,
    CollegianLastName NVARCHAR(MAX) NOT NULL,
    CollegianCode NCHAR(9) NOT NULL,
    CollegianNationalCode NCHAR(10) NOT NULL,
    CollegianPhoneNumber NCHAR(10) NOT NULL,
    CollegianAssignedRoomID INT NOT NULL,
    IsBlockManager BIT NOT NULL,
    ManagingBlockID INT NOT NULL,
    ManagingBlockName NVARCHAR(MAX),
    CollegianAddress NVARCHAR(MAX)
)







-- Switch to the MyAppDB database context
-- (All subsequent commands will apply to this database)
USE [Dorms_Project_SQL]

/*
 * Check if a table named 'Users' already exists in the database
 * This prevents errors if we try to create a table that already exists
 * sys.tables is a system view that contains all tables in the current database
 */
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BlocksTable')
-- If the table doesn't exist, create it with the following structure:
CREATE TABLE BlocksTable (
    -- Identity column that auto-increments (1,1 means starts at 1, increments by 1)
    -- PRIMARY KEY enforces uniqueness and creates a clustered index by default
    BlockID INT PRIMARY KEY IDENTITY(1,1),
    BlockName NVARCHAR(MAX) NOT NULL,
    BlockCapacity INT NOT NULL,
    BlockFloors INT NOT NULL,
    BlockRooms INT NOT NULL,
    BlockManagerID INT NOT NULL,
    BlockManagerName NVARCHAR(MAX) NOT NULL,
    LinkedDormID INT NOT NULL
)






-- Switch to the MyAppDB database context
-- (All subsequent commands will apply to this database)
USE [Dorms_Project_SQL]

/*
 * Check if a table named 'Users' already exists in the database
 * This prevents errors if we try to create a table that already exists
 * sys.tables is a system view that contains all tables in the current database
 */
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'RoomsTable')
-- If the table doesn't exist, create it with the following structure:
CREATE TABLE RoomsTable (
    -- Identity column that auto-increments (1,1 means starts at 1, increments by 1)
    -- PRIMARY KEY enforces uniqueness and creates a clustered index by default
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomNumber INT NOT NULL,
    RoomFloor INT NOT NULL,
    RoomCurrentCapacity INT NOT NULL,
    LinkedBlockID INT NOT NULL
)







-- Switch to the MyAppDB database context
-- (All subsequent commands will apply to this database)
USE [Dorms_Project_SQL]

/*
 * Check if a table named 'Users' already exists in the database
 * This prevents errors if we try to create a table that already exists
 * sys.tables is a system view that contains all tables in the current database
 */
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ItemsTable')
-- If the table doesn't exist, create it with the following structure:
CREATE TABLE ItemsTable (
    -- Identity column that auto-increments (1,1 means starts at 1, increments by 1)
    -- PRIMARY KEY enforces uniqueness and creates a clustered index by default
    ItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemType NVARCHAR(MAX) NOT NULL,
    ItemPartNumber NCHAR(3) NOT NULL,
    Item8DigitsID NCHAR (8) NOT NULL,
    ItemState NVARCHAR(MAX) NOT NULL,
    LinkedRoomID INT NOT NULL,
    LinkedCollegianID INT NOT NULL
)

