using System.Text.Json.Serialization;

// Summary:
// This internal class, Student, is part of the namespace FileProcessor.Json_Classes.
// It represents a student and is used for deserializing JSON data into an object.
namespace FileProcessor.Json_Classes
{
    internal class Student
    {
        // Summary:
        // Gets or sets the first name of the student.
        [JsonPropertyName("firstName")]
        public string FirstName;

        // Summary:
        // Gets or sets the last name of the student.
        [JsonPropertyName("lastName")]
        public string LastName;

        // Summary:
        // Gets or sets a flag indicating whether the student is enrolled.
        [JsonPropertyName("isEnrolled")]
        public bool IsEnrolled;

        // Summary:
        // Gets or sets the number of years the student has been enrolled.
        [JsonPropertyName("YearsEnrolled")]
        public int YearsEnrolled;

        // Summary:
        // Gets or sets the first address of the student.
        [JsonPropertyName("address1")]
        public Address Address1;


        // Summary:
        // Gets or sets the second address of the student.
        [JsonPropertyName("address2")]
        public Address Address2;

        // Summary:
        // Gets or sets a list of phone numbers associated with the student.

        [JsonPropertyName("phoneNnumbers")]
        public List<Phone> PhoneNumbers = new();
    }
}
