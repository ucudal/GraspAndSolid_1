//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product product, double quantity, int productCost, Equipment equipment, double time, int hourlyCost)
        {
            this.Quantity = quantity;
            this.Product = product;
            this.Time = time;
            this.Equipment = equipment;
            this.stepCost = (quantity*productCost) + (time*hourlyCost);
        }

        public Product Product { get; set; }

        public double Quantity { get; set; }

        public double Time { get; set; }

        public Equipment Equipment { get; set; }
        public double stepCost { get; set; } // Step es la clase experta en los costos de el step mencionado
    }
}