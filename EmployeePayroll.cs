﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_PayrollService
{
    public class EmployeePayroll
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
    }
}