using System.Text.Json.Serialization;

namespace FileProcessor.Json_Classes
{
    // Summary:
    // This internal class, Address, represents an address and is used as part of the student information in the FileProcessor.Json_Classes namespace.
    internal class Address
    {
        // Gets or sets the street address
        [JsonPropertyName("streetAddress")]
        public string StreetAddress;

        // Gets or sets the city.
        [JsonPropertyName("city")]
        public string City;

        // Gets or sets the state.
        [JsonPropertyName("state")]
        public string State;

        // Gets or sets the postal code
        [JsonPropertyName("postalCode")]
        public string PostalCode;
    }
}
