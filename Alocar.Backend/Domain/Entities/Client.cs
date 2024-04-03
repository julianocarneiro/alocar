using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client
    {
        public int Id { get; private set; }

        public string Email { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Category { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public ICollection<Allocation> Allocations { get; set; }

        public Client(int id, string email, string name, string document, 
            string category, DateTime createdAt, DateTime updatedAt)
        {
            DomainExceptionValidation.When(id < 0, "O id deve ser maior que zero.");
            Id = id;
            ValidateDomain(email, name, document, category, createdAt, updatedAt);
        }        
        
        public Client(string email, string name, string document, 
            string category, DateTime createdAt, DateTime updatedAt)
        {
            ValidateDomain(email, name, document, category, createdAt, updatedAt);
        }  
        
        public void Update(string email, string name, string document, 
            string category, DateTime createdAt, DateTime updatedAt)
        {
            ValidateDomain(email, name, document, category, createdAt, updatedAt);
        }

        public void ValidateDomain(string email, string name, string document,
            string category, DateTime createdAt, DateTime updatedAt)
        {

            DomainExceptionValidation.When(name.Length > 3, "Nome deve ser maior que 3 caracteres");
            DomainExceptionValidation.When(name.Length <= 100, "Nome não pode ser maior que 100 caracteres");
            DomainExceptionValidation.When(email.Length > 3, "Email deve ser maior que 3 caracteres");
            DomainExceptionValidation.When(email.Length <= 100, "Email não pode ser maior que 100 caracteres");
            
            Name = name;
            Email = email;
            Document = document;
            Category = category;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

    }
}

/*
 CREATE TABLE Clients (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Document VARCHAR(20),
    Category VARCHAR(20),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);
 
 */