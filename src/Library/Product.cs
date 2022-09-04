//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Product
    {
        public Product(string description, double unitCost, double unities)
        {
            this.Description = description;
            this.UnitCost = unitCost;
            this.Unities = unities;
            this.ProductCost = unitCost*unities;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
        public double Unities { get; set; } // La clase producto es expert en su unit cost y el total de unities, por ende debe conocerla
        public double ProductCost { get; set; }
    }
}