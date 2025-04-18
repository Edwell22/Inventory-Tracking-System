namespace TrackIt.Models

{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        // These two will help form something like "250g X 20 Units"
        public string UnitWeight { get; set; } // e.g., "250g"
        public int UnitCount { get; set; } // e.g., 20

        public string Group { get; set; } // e.g., "Economy Packs", "Cream Biscuits"

        public string ImageUrl { get; set; } // URL to the product image

        public DateTime ManufacturedDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string ReturnStatus { get; set; } // e.g., "Returned", "Not Returned"

        public string DamageReports { get; set; } // e.g., "None", "Damaged during dispatch"

        public string SupplyStatus { get; set; } // e.g., "In Stock", "Supplied to Market"

        // Read-only combined display property for unit measurement
        public string UnitMeasurement => $"{UnitWeight} X {UnitCount} Units";

        // Formatted dates
        public string ManufacturedDateFormatted => ManufacturedDate.ToString("dd-MM-yyyy");

        public string ExpiryDateFormatted => ExpiryDate.ToString("dd-MM-yyyy");
    }
}
