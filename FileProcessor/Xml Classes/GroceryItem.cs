using System.Xml.Serialization;

// Summary:
// This code is defined within the namespace FileProcessor in a folder of Xml_Classes.
// It represents a class, GroceryItem, which is intended for XML serialization.
// The class is annotated with XML attributes to specify the XML element names for serialization.


namespace FileProcessor.Xml_Classes
{

    // The GroceryItem class represents an item in a grocery list. It is designed for XML serialization.
    [XmlRoot(ElementName = "item")]
    public class GroceryItem
    {

        // Gets or sets the name of the grocery item.
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }


        // Gets or sets the price of the grocery item.

        [XmlElement(ElementName = "price")]
        public string Price { get; set; }


        // Gets or sets the unit of measure (UOM) for the grocery item.
        [XmlElement(ElementName = "uom")]
        public string Uom { get; set; }
    }
}
