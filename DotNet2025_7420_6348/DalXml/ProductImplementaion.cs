using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal;

internal class ProductImplementaion : IProduct
{
    const string PRODUCTS_FILE_PATH = "../xml/products.xml";
    public int Create(Product p)
    {
        XElement productsList = XElement.Load(PRODUCTS_FILE_PATH);

        int myId = DalXml.Config.ProductNum;

        productsList.Add(new XElement("Product",
            new XElement("Id", myId),
            new XElement("Name", p.Name),
            new XElement("Category", p.Category),
            new XElement("Price", p.Price),
            new XElement("InStock", p.InStock)
            ));

        productsList.Save(PRODUCTS_FILE_PATH);

        return myId;
    }

    public void Delete(int id)
    {
        XElement productsList = XElement.Load(PRODUCTS_FILE_PATH);

        XElement foundProd = productsList.Descendants("Id").FirstOrDefault(ID => int.Parse(ID.Value) == id);
        if (foundProd != null)
        {
            foundProd.Parent.Remove();
            productsList.Save(PRODUCTS_FILE_PATH);
        }
        else
            throw new DalIDNotFoundException($"Product with id: {id} was not found");
    }

    public Product? Read(int id)
    {
        XElement productsList = XElement.Load(PRODUCTS_FILE_PATH);
        XElement foundProd = productsList.Descendants("Id").FirstOrDefault(ID => int.Parse(ID.Value) == id);
        if (foundProd != null)
        {
            foundProd = foundProd.Parent;
            return new Product(int.Parse(foundProd.Element("Id").Value),
                foundProd.Element("Name") != null ? foundProd.Element("Name").Value : null,
                foundProd.Element("Category") != null ? (Category)Enum.Parse(typeof(Category), foundProd.Element("Category").Value) : 0,
                foundProd.Element("Price") != null ? double.Parse(foundProd.Element("Price").Value) : 0,
                foundProd.Element("InStock") != null ? int.Parse(foundProd.Element("InStock").Value) : 1);
        }
        else
         
            throw new DalIDNotFoundException($"Product with id: {id} was not found");
    }

    public Product? Read(Func<Product, bool> filter)
    {

        List<Product> products = ReadAll();
        Product foundProd= products.FirstOrDefault(p => filter(p));
        if (foundProd != null)
            return foundProd;
        else throw new DalIDNotFoundException("Product with requested conditions was not found");

    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        XElement productsList = XElement.Load(PRODUCTS_FILE_PATH);
        List<Product> products = (from product in productsList.Elements()
                                    select new Product(int.Parse(product.Element("Id").Value),
                                                       product.Element("Name") != null ? product.Element("Name").Value : null,
                                                       product.Element("Category") != null ? (Category)Enum.Parse(typeof(Category), product.Element("Category").Value) : 0,
                                                       product.Element("Price") != null ? double.Parse(product.Element("Price").Value) : 0,
                                                       product.Element("InStock") != null ? int.Parse(product.Element("InStock").Value) : 1)
                                                ).ToList();
        if(filter != null)
            return products.Where<Product>(filter).ToList();
        return products;
    }

    public void Update(Product p)
    {
        XElement productsList = XElement.Load(PRODUCTS_FILE_PATH);
        XElement foundProd = productsList.Descendants("Id").FirstOrDefault(ID => int.Parse(ID.Value) == p.Id).Parent;
        if (foundProd != null)
        {
            foundProd.Element("Id").SetValue(p.Id);
            foundProd.Element("Name").SetValue(p.Name);
            foundProd.Element("Category").SetValue(p.Category);
            foundProd.Element("Price").SetValue(p.Price);
            foundProd.Element("InStock").SetValue(p.InStock);
            productsList.Save(PRODUCTS_FILE_PATH);
        }
        else
            throw new DalIDNotFoundException($"Product with id: {p.Id} was not found");
    }
}
