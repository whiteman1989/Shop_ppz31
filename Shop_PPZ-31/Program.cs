﻿using System;
using Shop_PPZ_31.models;
using Shop_PPZ_31.views;

namespace Shop_PPZ_31
{
    class Program
    {
        internal MainMenu MainMenu { get; set; }
        static void Main(string[] args)
        {
            /*DBItem<Product> dbProduct = DBItem<Product>.DBInstance();
            DBItem<Description> dbDescription = DBItem<Description>.DBInstance();
            DBItem<Customer> dbCustomer = DBItem<Customer>.DBInstance();
            DBItem<Employee> dbEmployee = DBItem<Employee>.DBInstance();
            DBItem<Order> dbOrder = DBItem<Order>.DBInstance();
            DBItem<ProductOrder> dbProductOrder = DBItem<ProductOrder>.DBInstance();

            DBInitializer dbInit = new DBInitializer();

            tests.TestHrManager testHrManager = new tests.TestHrManager();
            testHrManager.RunTest();*/

            Program program = new Program();
            program.MainMenu = new MainMenu();
            program.MainMenu.Run();
            //views.HrMainMenu hrMainMenu = new HrMainMenu(Controllers.HrManager.GetAll());
            //hrMainMenu.Run();


            //Console.ReadLine();
        }
    }
}
