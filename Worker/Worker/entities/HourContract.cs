using System;
using System.Collections.Generic;
using System.Text;

namespace Worker.entities
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }
        public HourContract(DateTime date,double valorhora,int horas)
        {
            Date = date;
            ValuePerHour = valorhora;
            Hours = horas;
        }
        public double TotalHoras()
        {
            return Hours * ValuePerHour;
        }
    }
}
