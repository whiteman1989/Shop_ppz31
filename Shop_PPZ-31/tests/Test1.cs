﻿using System;
using System.Collections.Generic;
using System.Text;
using Shop_PPZ_31.models;

namespace Shop_PPZ_31.tests
{
    class Test1
    {
        public void Runtest1()
        {
            DBItem<Product> dbProduct = DBItem<Product>.DBInstance();
            DBItem<Description> dbDescription = DBItem<Description>.DBInstance();
            DBItem<Customer> dbCustomer = DBItem<Customer>.DBInstance();
            DBItem<Employee> dbEmployee = DBItem<Employee>.DBInstance();
            DBItem<Order> dbOrder = DBItem<Order>.DBInstance();
            DBItem<ProductOrder> dbProductOrder = DBItem<ProductOrder>.DBInstance();

            foreach (Customer customer in dbCustomer.Items)
            {
                Console.WriteLine(customer);

                foreach (Order order in dbOrder.Items)
                {
                    if (order.CustomerId == customer.Id)
                    {
                        Console.WriteLine("\t" + order);

                        foreach (Employee employee in dbEmployee.Items)
                        {
                            if (employee.Id == order.EmployeeId)
                            {
                                Console.WriteLine("\t\t" + employee);
                            }
                        }
                        foreach (ProductOrder productOrder in dbProductOrder.Items)
                        {
                            if (productOrder.OrderId == order.Id)
                            {
                                Console.WriteLine("\t\t\t" + productOrder);

                                foreach (Product product in dbProduct.Items)
                                {
                                    if (product.Id == productOrder.ProductId)
                                    {
                                        Console.WriteLine("\t\t\t\t" + product);

                                        foreach (Description description in dbDescription.Items)
                                        {
                                            if (description.ProductId == product.Id)
                                            {
                                                Console.WriteLine("\t\t\t\t\t" + description);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
