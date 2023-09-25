﻿using SalesWebMVC.Models.Enums;
using System;

namespace SalesWebMVC.Models
{
    public class SalesRecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public SalesRecords() { }

        public SalesRecords(int id, DateTime date, double amount, SalesStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
        }
    }



}
