//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }
        public double FinalCost { get; set; }

        
        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void GetProductionCost() //Recipe es la clase experta que debería encargarse de calcular el costo de la receta
        {
            this.FinalCost = 0;
            foreach (Step step in this.steps)
            {
                this.FinalCost = this.FinalCost + step.stepCost;
            }
        }
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Product.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} (costo: {step.stepCost})");
            }
            Console.WriteLine($"El costo total de la receta es: ${this.FinalCost}");
        }
    }
}