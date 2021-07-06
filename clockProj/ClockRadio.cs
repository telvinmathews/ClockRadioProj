using System;
namespace clockProj
{
    public class ClockRadio
    {
            //member variables
            public string currentTime;
            public string currentStation;
            public bool alarmStatus;
            public string alarmTime;

            //constructor
            public ClockRadio(string currenTime, string currentStation, bool alarmStatus, string alarmTime)
            {
                this.currentTime = currenTime;
                this.currentStation = currentStation;
                this.alarmStatus = alarmStatus;
                this.alarmTime = alarmTime;
            }

            //member methods
            public string GetCurrentTime()
            {
            Console.WriteLine($"Current time is: {currentTime}");
            return currentTime;
            }

            public void ChangeCurrentTime()
        {
            Console.WriteLine("Change current time. ");
            currentTime = Console.ReadLine();
        }

            public string GetCurrentStaion()
        {
            Console.WriteLine($"Current station is: {currentStation}");
            return currentStation;
        }

            public void ChangeStation()
        {
            Console.WriteLine("Change station. ");
            currentStation = Console.ReadLine();
        }
        //jhbsljbl

        public string GetAlarmTime()
        {
            Console.WriteLine($"Current alarm time is: {alarmTime}");
            return alarmTime;
        }

        public void ChangeAlarmTime()
        {
            Console.WriteLine("Change alarm time. ");
            alarmTime = Console.ReadLine();
        }

        public bool AlarmOn()
        {
           return alarmStatus = true;
        }

        public bool AlarmOff()
        {
            return alarmStatus = false; 
        }
            



        }
    }
