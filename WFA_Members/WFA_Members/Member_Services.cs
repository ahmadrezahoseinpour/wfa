using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WFA_Members
{
    public class Member_Services : IMembers
    {
        private string url = "https://localhost:7132/";
        HttpClient client = new HttpClient();

        //GetAllCustomers
        public List<Entity> GetAllCustomers()

        {

            var result = client.GetStringAsync(url + "GetAllCustomers").Result;
            var Persons = JsonConvert.DeserializeObject<List<Entity>>(result);
            return Persons;


        }

        //GetCustomerById
        public Entity GetCustomerById(int customer_ID)
        {
            var result = client.GetStringAsync(url + $"GetCustomerById?Customer_Id={customer_ID}").Result;
            Entity person = JsonConvert.DeserializeObject<Entity>(result);
            return person;
        }

        //DeleteCustomerById
        public bool Delete(int customer_ID)
        {
            try
            {
                var result = client.DeleteAsync(url + $"DeleteCustomerById?Customer_Id={customer_ID}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        //AddNewCustomer
        public bool Insert(Entity person)
        {
//            var result = client.PostAsync(url + $"AddNewCustomer?");
            return true;
        }
        //UpdateCustomer
        public bool Update(Entity person)
        {
    //        string json = JsonConvert.SerializeObject(person);
  //          StreamContent content = new System.Net.Http.StringContent(json, Encoding.UTF8)
  return true;
        }
    }
}
