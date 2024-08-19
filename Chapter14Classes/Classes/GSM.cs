using System;

namespace Classes
{
    public class GSM
    {
        public string Model {get; set;}
        public string Manufacturer{get; set;}
        public decimal Price{get; set;}
        public string Owner{get; set;}
        private static GSM NokiaN95 = GetNokiaN95();

        public GSM() { }
        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
        }

        public string GetGSMInfo()
        {
            string pmodel = "ItelA15";
            string panufacturer = "Itel";
            string pPrice = "75000";
            string powner = "Yusuff Ahmad";

            string Phone1 = $"Model: {pmodel}Manufacturer: {panufacturer} Price: {pPrice} Owner: {powner}";
            return Phone1;
        }
        public static GSM GetNokiaN95()
        {
            GSM NokiaN95 = new GSM("ItelA15", "Itel", 75000, "Yusuff Ahmad");
            return NokiaN95;
        }
    }
}