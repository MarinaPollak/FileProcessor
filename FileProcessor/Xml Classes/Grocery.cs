using System.Xml.Serialization;

// Summary:
// This code is defined within the namespace FileProcessor in a folder Xml_Classes.
// It represents a class, Grocery, which is intended for XML serialization.
// The class is annotated with XML attributes to specify the XML element names for serialization.
namespace FileProcessor.Xml_Classes
{


    // The Grocery class represents a collection of grocery items in a menu. It is designed for XML serialization.
    [XmlRoot(ElementName = "menu")]
    public class Grocery
    {
        // Gets or sets a list of grocery items in the menu.
        [XmlElement("item")]
        public List<GroceryItem> Items { get; set; }
    }
}
