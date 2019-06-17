using System;
using System.Collections.Generic;
using System.Text;
using Worker.entities;
using Worker.entities.enums;

namespace Worker.entities
{
    class worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public worker()
        {

        }
        public worker(string name,WorkerLevel level,double Salario,Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = Salario;
            Departament = departament;
        }
        public void AddContract(HourContract hora)
        {
            Contracts.Add(hora);
        }
        public void RemoveContract(HourContract hora)
        {
            Contracts.Remove(hora);
        }
        public double InCome(int ano,int mes)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year==ano&&contract.Date.Month==mes)
                {
                    sum += contract.TotalHoras();
                }
            }
            return sum;
        }
    }
}
