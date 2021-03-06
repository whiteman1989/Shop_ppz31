﻿using System;
using System.Collections.Generic;
using System.Text;
using Shop_PPZ_31.models;
using Shop_PPZ_31.models.viewModels;

namespace Shop_PPZ_31.controllers
{
    static class ProductManager
    {
        static DBItem<Product> dbProducts = DBItem<Product>.DBInstance();
        static DBItem<Description> dbDescriptions = DBItem<Description>.DBInstance();

        #region Product CRUD
        //**CREATE
        public static Product CreateProduct(Product product)
        {
            try
            {
                return dbProducts.AddItem(product);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }
        }
        public static Description CreateProductDescription(Description productDescription)
        {
            try
            {
                return dbDescriptions.AddItem(productDescription);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }
        }

        //**READ ALL
        public static List<ProductView> GetAll ()
        {
            List <ProductView> productViews = new List<ProductView>();
            var products = dbProducts.Items;
            var descriptions = dbDescriptions.Items;
            
            foreach (Product product in products)
            {
                foreach (Description description in descriptions)
                {
                    if(description.ProductId == product.Id)
                    {
                        ProductView productView = new ProductView();
                        productView.ProductV = product;
                        productView.DescriptionV = description;

                        productViews.Add(productView);

                        break;
                    }
                }
            }

            return productViews;
        }

        //**READ 1
        public static ProductView GetById(int id)
        {
            ProductView productView = new ProductView();
            try
            {
                productView.ProductV = dbProducts.FindById(id);
                productView.DescriptionV = null;
                foreach(Description description in dbDescriptions.Items)
                {
                    if(description.ProductId == productView.ProductV.Id)
                    {
                        productView.DescriptionV = description;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }
            
            return productView;
        }
        //**UPDATE PRODUCT
        public static void ProductUpdate (Product product)
        {
            try
            {
                dbProducts.Update(product);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }
        }
        //**UPDATE PRODUCT DESCRIPTION
        public static void DescriptionUpdate (Description description)
        {
            try
            {
                dbDescriptions.Update(description);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }
        }
        //DELETE
        public static void Delete(int id)
        {
            Product product;
            try
            {
                product = dbProducts.FindById(id);

                foreach (Description description in dbDescriptions.Items)
                {
                    if (description.ProductId == product.Id) dbDescriptions.Delete(description.Id);
                }

                dbProducts.Delete(id);
            }
            catch (Exception e)
            {

                Console.Error.WriteLine(e);
            }
        }

        #endregion
    }
}
