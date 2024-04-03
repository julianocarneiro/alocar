-- Create Clients table
CREATE TABLE Clients (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Document VARCHAR(20),
    Category VARCHAR(20),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);

-- Create Vehicles table
CREATE TABLE Vehicles (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Brand VARCHAR(100),
    ManufactureModel VARCHAR(4),
    ManufactureYear VARCHAR(4),
    Color VARCHAR(30),
    Plate VARCHAR(20) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);

-- Create Allocation table
CREATE TABLE Allocations (
    Id INT PRIMARY KEY,
    ClientId INT,
    VehicleId INT,
    AllocationDate DATE,
    ReturnDate DATE,
    Finished BIT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ClientId) REFERENCES Clients(id),
    FOREIGN KEY (VehicleId) REFERENCES Vehicles(id)
);
