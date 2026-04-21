using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class CustomerImplementation : BlApi.ICustomer
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(Customer c)
        {
            try
            {
                return _dal.Customer.Create(Tools.ConvertBOCustomerToDOCustomer(c));
            }
            catch (DO.DalAlreadyExists dae)
            {
                throw new BO.BlSaleAlreadyExistsException($"Customer with id {c.Id} already exists", dae);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlSaleIdNotFoundException(c.Id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return -1;
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlProductIdNotFoundException(id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool Exists(Customer c)
        {
            var customer=_dal.Customer.Read(c.Id);
            return customer != null;
        }

        public Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id)!.ConvertDOCustomerToBOCustomer();
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlCustomerIdNotFoundException(id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            try
            {
                _dal.Customer.Read(p => filter(p.ConvertDOCustomerToBOCustomer()))!.ConvertDOCustomerToBOCustomer();
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            try
            {
                return _dal.Customer.ReadAll().Select(p => p.ConvertDOCustomerToBOCustomer()).Where(filter!).ToList()!;
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public void Update(Customer c)
        {
            try
            {
                _dal.Customer.Create(Tools.ConvertBOCustomerToDOCustomer(c));
            }
            catch (DO.DalAlreadyExists dae)
            {
                throw new BO.BlCustomerAlreadyExistsException($"Customer with id {c.Id} already exists", dae);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlCustomerIdNotFoundException(c.Id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
