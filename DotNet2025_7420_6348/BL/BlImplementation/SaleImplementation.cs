using BlApi;
using BO;
using Dal;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class SaleImplementation : BlApi.ISale
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(Sale s)
        {
            try
            {
                return _dal.Sale.Create(Tools.ConvertBOSaleToDOSale(s));
            }
            catch(DO.DalAlreadyExists dae)
            {
                throw new BO.BlSaleAlreadyExistsException($"Sale with id {s.Id} already exists", dae);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception",dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlProductIdNotFoundException(s.ProductId, didnfe);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return -1;
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlSaleIdNotFoundException(id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Sale? Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id).ConvertDOSaleToBOSale();
            }
            catch (DO.DalAlreadyExists dae)
            {
                throw new BO.BlSaleAlreadyExistsException($"Sale with id {id} already exists", dae);
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlSaleIdNotFoundException(id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                _dal.Sale.Read(p => filter(p.ConvertDOSaleToBOSale()))!.ConvertDOSaleToBOSale();
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

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return _dal.Sale.ReadAll().Select(p => p.ConvertDOSaleToBOSale()).ToList();
                }
                return _dal.Sale.ReadAll().Select(p => p.ConvertDOSaleToBOSale()).Where(filter!).ToList()!;
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

        public void Update(Sale sale)
        {
            try
            {
                _dal.Sale.Update(sale.ConvertBOSaleToDOSale());
            }
            catch (DO.DalConfigExceptions dce)
            {
                throw new BO.BlConfigExceptions("Configuration Exception", dce);
            }
            catch (DO.DalIDNotFoundException didnfe)
            {
                throw new BO.BlSaleIdNotFoundException(sale.Id, didnfe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
