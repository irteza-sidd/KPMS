using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Class1
    {
    }
    public class BusinessLayer
    {
        DataLayer obj = new DataLayer();
        public int log(string user,string pass)
        {
            int a = obj.login(user, pass);
            return a;
        }
        public int InsertCar(string fname, string lname, string plate, string contact, string brand, string color, bool cplc, bool wash, bool shade)
        {
            int a=obj.InsertCarData( fname,  lname, plate, contact, brand,color,cplc, wash,shade);
            return a;
        }
        public int InsertBus(string fname, string lname, string contact, string plate, string brand, string color, bool cplc, bool wash, bool shade)
        {
           int a= obj.InsertBusData(fname, lname, contact, plate, brand, color, cplc, wash, shade);
            return a;
        }
        public int InsertScooter(string fname, string lname, string contact, string plate, string brand, string color, bool cplc, bool wash, bool shade)
        {
            int a=obj.InsertScooterData(fname, lname, contact, plate, brand, color, cplc, wash, shade);
            return a;
        }
        public int DepartureofCar(string fname ,string lname,string plate)
        {
            int a=obj.CarDeparture(fname, lname,plate);
            return a;
        }
        public int DepartureofBus(string fname, string lname, string plate)
        {
            int a=obj.BusDeparture(fname, lname, plate);
            return a;
        }
        public int DepartureofScooter(string fname, string lname, string plate)
        {
            int a=obj.ScooterDeparture(fname, lname, plate);
            return a;
        }
        public string TotalNoOfVehicles()
        {
            string a = obj.Total();
            return a;
        }
        public string CarsAmountCollected()
        {
            string a = obj.CarsCash();
            return a;
        }
        public string BusesAmountCollected()
        {
            string a = obj.BusesCash();
            return a;
        }
        public string ScootersAmountCollected()
        {
            string a = obj.ScootersCash();
            return a;
        }
        public string Noofcars()
        {
            string a = obj.NoOfCars();
            return a;
        }
        public string Noofbuses()
        {
            string a = obj.NoOfBuses();
            return a;
        }
        public string Noofscooters()
        {
            string a = obj.NoOfScooters();
            return a;
        }
        public  string vehicleswash()
        {
            string a = obj.Washed();
            return a;
        }
        public string vehicleshade()
        {
            string a = obj.Shaded();
            return a;
        }
        public string allcash()
        {
            string a = obj.Totalam();
            return a;
        }
    }
}
