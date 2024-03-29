﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComissionBankAdvisor.Models
{
    public class Client
    {
        public int Id { get; set; }
        public DateTime Record { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Details { get; set; }
        public string ClientCode { get; set; }
        public string AdvisorInitials { get; set; }

        public Client()
        {

        }

        public Client(int id, string name, string email, string cpf, string telefone, DateTime birthday, string address, string details)
        {
            Id = id;
            Name = name;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Birthday = birthday;
            Address = address;
            Details = details;
        }

        public Client(string clientName, string clientCode,string advisorInitials)
        {
            Name = clientName;
            ClientCode = clientCode;
            AdvisorInitials = advisorInitials;
        }

        public Client(string name, string advisorInitials)
        {
            Name = name;
            AdvisorInitials = advisorInitials;
        }

        public Client(string clientName, string clientCode, string advisorInitials, string cpf)
        {
            Name = clientName;
            ClientCode = clientCode;
            AdvisorInitials = advisorInitials;
            Cpf = cpf;
        }
    }
}
