using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Members
{
    public interface IMembers
    { 
        List<Entity> GetAllCustomers();
        Entity GetCustomerById(int customer_ID);
        bool Delete(int customer_ID);
        bool Insert(Entity person);
        bool Update(Entity person);
    }
}
