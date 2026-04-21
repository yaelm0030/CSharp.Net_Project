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
    internal class ProductImplementation : BlApi.IProduct
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(Product p)
        {
            try
            {
                return _dal.Product.Create(Tools.ConvertBOProductToDOProduct(p));
            }
            catch (DO.DalAlreadyExists dae)
            {
                throw new BO.BlProductAlreadyExistsException($"Product with id {p.Id} already exists", dae);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlProductIdNotFoundException(p.Id, didnfe);
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
                _dal.Product.Delete(id);
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

        public List<Sale> GetSales(ProductInOrder p)
        {
            try
            {
                return _dal.Sale.ReadAll().Select(s=>s.ConvertDOSaleToBOSale()).Where(s=>s.ProductId==p.Id).ToList();
            }
            catch (DO.DalAlreadyExists dae)
            {
                throw new BO.BlProductAlreadyExistsException($"Product with id {p.Id} already exists", dae);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlProductIdNotFoundException(p.Id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(id)!.ConvertDOProductToBOProduct();
            }
            catch (DO.DalAlreadyExists dae)
            {
                throw new BO.BlProductAlreadyExistsException($"Product with id {id} already exists", dae);
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
            return null;
        }

        public Product? Read(Func<Product, bool> filter)
        {
            try
            {
                _dal.Product.Read(p => filter(p.ConvertDOProductToBOProduct()))!.ConvertDOProductToBOProduct();
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

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            try
            {
                return _dal.Product.ReadAll().Select(p=>p.ConvertDOProductToBOProduct()).Where(filter!).ToList()!;
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

        public void Update(Product p)
        {
            try
            {
                _dal.Product.Create(Tools.ConvertBOProductToDOProduct(p));
            }
            catch (DO.DalAlreadyExists dae)
            {
                throw new BO.BlProductAlreadyExistsException($"Product with id {p.Id} already exists", dae);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlProductIdNotFoundException(p.Id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
