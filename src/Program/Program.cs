//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    public class Program
    { // Se utilizó patrón Expert en cada clase para asignar las nuevas funcionalidades necesitadas a su clase correspondiente
        private static ArrayList productCatalog = new ArrayList();

        private static ArrayList equipmentCatalog = new ArrayList();

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = GetProduct("Café con leche");
            recipe.AddStep(new Step(GetProduct("Café"), 0.100, 50, GetEquipment("Cafetera"), 0.25, 1000));
            recipe.AddStep(new Step(GetProduct("Leche"), 0.200, 300, GetEquipment("Hervidor"), 0.25, 2000));
            recipe.GetProductionCost(); // Se agrega un calculador de costo de la receta, el cual es un método de la clase Recipe
            recipe.PrintRecipe();
        }

        private static void PopulateCatalogs() //A cada producto se le sumó la cantidad necesaria, en función de poder calcular el precio por las horas o cantidades utilizadas
        {
            AddProductToCatalog("Café", 100, 50);
            AddProductToCatalog("Leche", 200, 300);
            AddProductToCatalog("Café con leche", 300, 0);

            AddEquipmentToCatalog("Cafetera", 1000, 0.25);
            AddEquipmentToCatalog("Hervidor", 2000, 0.10);
        }

        private static void AddProductToCatalog(string description, double unitCost, double unities)
        {
            productCatalog.Add(new Product(description, unitCost, unities));
        }

        private static void AddEquipmentToCatalog(string description, double hourlyCost, double hoursNeeded)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost, hoursNeeded));
        }

        private static Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        private static Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        private static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        private static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}
