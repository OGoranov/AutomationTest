using DemoQA.Models;

namespace DemoQA.Factories
{
    class AutomationPracticeFactory
    {
        public static AutomationPracticeModel Create()
        {
            return new AutomationPracticeModel
            {
                emailAddressField = "testaccount@abv.bg",
                mobilePhoneField = "0881001",
                firstNameField = "Firstname",
                lastNameField = "Lastname",
                addressField = "Address 12",
                passwordField = "password123",
                cityField = "city",
                postalZipField = "12345",
                stateField = "Arizona",
            };
        }
    }
}
