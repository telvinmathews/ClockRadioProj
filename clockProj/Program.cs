using System;

namespace clockProj
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio clockRadio1 = new ClockRadio("5:30","95.7 FM",false,"3:00am");
            clockRadio1.AlarmOn();
            clockRadio1.GetAlarmTime();
            clockRadio1.ChangeAlarmTime();
            clockRadio1.GetAlarmTime();
            clockRadio1.GetCurrentStaion();
            clockRadio1.ChangeStation();
            clockRadio1.GetCurrentStaion();
            clockRadio1.AlarmOff();


        }
    }
}
