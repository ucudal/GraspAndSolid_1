//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost, double hoursNeeded)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
            this.HoursNeeded = hoursNeeded;
            this.EquipmentCost = hourlyCost*hoursNeeded;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
        public double HoursNeeded { get; set; }
        public double EquipmentCost { get; set; } // La clase equipment es expert en su Hourly cost y el total de horas, por ende debe conocer estas variables
    }
}