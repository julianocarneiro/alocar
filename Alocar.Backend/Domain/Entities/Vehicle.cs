using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; private set; }

        public string Name { get; private set; }
        public string Brand { get; private set; }
        public string ManufactureModel { get; private set; }
        public string ManufactureYear { get; private set; }
        public string Color { get; private set; }
        public string Plate { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Vehicle(int id, string name, string brand, string manufactureModel, 
            string manufactureYear, string color, string plate, 
            DateTime createdAt, DateTime updatedAt)
        {
            DomainExceptionValidation.When(id < 0, "O id deve ser maior que zero.");
            Id = id;
            ValidateDomain(name, brand, manufactureModel, manufactureYear, color, plate, createdAt, updatedAt);
        }

        public Vehicle( string name, string brand, string manufactureModel, 
            string manufactureYear, string color, string plate, 
            DateTime createdAt, DateTime updatedAt)
        {
            ValidateDomain(name, brand, manufactureModel, manufactureYear, color, plate, createdAt, updatedAt);
        }

        public void Update(string name, string brand, string manufactureModel,
            string manufactureYear, string color, string plate,
            DateTime createdAt, DateTime updatedAt)
        {
            ValidateDomain(name, brand, manufactureModel, manufactureYear, color, plate, createdAt, updatedAt);
        }

        public void ValidateDomain(string name, string brand, string manufactureModel,
            string manufactureYear, string color, string plate,
            DateTime createdAt, DateTime updatedAt)
        {

            DomainExceptionValidation.When(name.Length > 3, "Nome deve ser maior que 3 caracteres");
            DomainExceptionValidation.When(name.Length <= 100, "Nome não pode ser maior que 100 caracteres");
            DomainExceptionValidation.When(manufactureModel.Length == 4, "Modelo deve ter 4 caracteres");
            DomainExceptionValidation.When(manufactureYear.Length == 4, "Ano deve ter 4 caracteres");

            Name = name;
            Brand = brand;
            ManufactureModel = manufactureModel;
            ManufactureYear = manufactureYear;
            Color = color;
            Plate = plate;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

    }
}


/*
 
 CREATE TABLE Vehicles (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Brand VARCHAR(100),
    ManufactureModel VARCHAR(100),
    ManufactureYear VARCHAR(4),
    Color VARCHAR(50),
    Plate VARCHAR(20) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);
 
 */