using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Call
    {
        public DateTime DateOfCall;
        public DateTime CallStartTime;
        public string CallDuration;
        public static double Tariff = 0.37;
        public static List<Call> CallHistories { get; set; }
        public Call(DateTime dateOfCall, DateTime callStartTime, string callDuration, double tariff)
        {
            DateOfCall = dateOfCall;
            CallStartTime = callStartTime;
            CallDuration = callDuration;
            Tariff = tariff;
        }

        public double TotalCallsAmount()
        {
            double total = 0;
            foreach (var call in CallHistories)
            {
                total += Call.Tariff;
            }
            return total;
        }
        public void AddCall1()
        {
            DateTime dateOfCall = DateTime.Parse("24-9-2022");
            DateTime callStartTime = DateTime.Now.AddHours(14);
            string callDuration = "30 minutes";
            double tariff = 0.23;
            Call MyCall = new Call(dateOfCall, callStartTime, callDuration, tariff);
            CallHistories.Add(MyCall);
        }

        public void RemoveCall(Call MyCall)
        {
            CallHistories.Remove(MyCall);
        }
        public void DeleteCalls()
        {
            CallHistories.Clear();
        }

        public string AddInfo()
        {
            return $"DateOfCall: {DateTime.Parse("24-9-2022")} CallStartTime: {DateTime.Now.AddHours(14)} CallDuration: 30 minutes";
        }
    }
}
