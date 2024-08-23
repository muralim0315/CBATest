
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace PetStoreApiTests.StepDefinitions
{
    [Binding]
    public class PetStoreStepDefinitions
    {
        private const string BaseUrl = "https://petstore.swagger.io/v2";
        private readonly RestClient _client;
        private RestRequest _request;
        private RestResponse _response;

        public PetStoreStepDefinitions()
        {
            _client = new RestClient(BaseUrl);
        }

        // Add Pet Feature Steps
        [Given(@"I have the following pet data")]
        public void GivenIHaveTheFollowingPetData(Table table)
        {
            var petData = table.Rows[0];
            int.TryParse(petData["id"], out int id);
            string name = petData["name"];
            string status = petData["status"];

            _request = new RestRequest("/pet", Method.Post);
            _request.AddJsonBody(new
            {
                id = id,
                name = name,
                status = status
            });
        }

        [When(@"I add the pet to the store")]
        public void WhenIAddThePetToTheStore()
        {
            _response = _client.Execute(_request);
        }

        [Then(@"the response should be successful")]
        public void ThenTheResponseShouldBeSuccessful()
        {
            Assert.IsTrue(_response.IsSuccessful, $"Expected success but got: {_response.Content}");
        }

        [Then(@"the response should not be successful")]
        public void ThenTheResponseShouldNotBeSuccessful()
        {
            Assert.IsFalse(_response.IsSuccessful, $"Expected failure but got: {_response.Content}");
        }

        // Get Pet Feature Steps
        [Given(@"I have a valid pet ID")]
        public void GivenIHaveAValidPetID()
        {
            _request = new RestRequest("/pet/{petId}", Method.Get);
            _request.AddUrlSegment("petId", 12345);
        }

        [Given(@"I have an invalid pet ID")]
        public void GivenIHaveAnInvalidPetID()
        {
            _request = new RestRequest("/pet/{petId}", Method.Get);
            _request.AddUrlSegment("petId", -1);
        }

        [When(@"I get the pet by ID")]
        public void WhenIGetThePetByID()
        {
            _response = _client.Execute(_request);
        }

        // Update Pet Feature Steps
        [Given(@"I have the following updated pet data")]
        public void GivenIHaveTheFollowingUpdatedPetData(Table table)
        {
            var petData = table.Rows[0];
            int.TryParse(petData["id"], out int id);
            string name = petData["name"];
            string status = petData["status"];

            _request = new RestRequest("/pet", Method.Put);
            _request.AddJsonBody(new
            {
                id = id,
                name = name,
                status = status
            });
        }

        [When(@"I update the pet in the store")]
        public void WhenIUpdateThePetInTheStore()
        {
            _response = _client.Execute(_request);
        }

        // Delete Pet Feature Steps
        [When(@"I delete the pet")]
        public void WhenIDeleteThePet()
        {
            _response = _client.Execute(_request);
        }

        // Find Pets by Status Feature Steps
        [Given(@"I have the status (.*)")]
        public void GivenIHaveTheStatus(string status)
        {
            _request = new RestRequest("/pet/findByStatus", Method.Get);
            _request.AddParameter("status", status);
        }       

        [When(@"I search for pets by status")]
        public void WhenISearchForPetsByStatus()
        {
            _response = _client.Execute(_request);
        }

        [Given(@"I have an invalid status (.*)")]
        public void GivenIHaveAnInvalidStatus(string status)
        {
            _request = new RestRequest("/pet/findByStatus", Method.Get);
            _request.AddParameter("status", status); // This will pass the invalid status parameter
        }


        // Update Pet with Form Data Feature Steps
        [Given(@"I have a valid pet ID and valid form data")]
        public void GivenIHaveAValidPetIDAndValidFormData(Table table)
        {
            var formData = table.Rows[0];
            string name = formData["name"];
            string status = formData["status"];

            _request = new RestRequest("/pet/{petId}", Method.Post);
            _request.AddUrlSegment("petId", 12345);
            _request.AddParameter("name", name);
            _request.AddParameter("status", status);
        }

        [Given(@"I have an invalid pet ID and valid form data")]
        public void GivenIHaveAnInvalidPetIDAndValidFormData(Table table)
        {
            var formData = table.Rows[0];
            string name = formData["name"];
            string status = formData["status"];

            _request = new RestRequest("/pet/{petId}", Method.Post);
            _request.AddUrlSegment("petId", -1);
            _request.AddParameter("name", name);
            _request.AddParameter("status", status);
        }

        [When(@"I update the pet using form data")]
        public void WhenIUpdateThePetUsingFormData()
        {
            _response = _client.Execute(_request);
        }

        // Upload Pet Image Feature Steps
        [Given(@"I have a valid pet ID and a valid image")]
        public void GivenIHaveAValidPetIDAndAValidImage()
        {
            _request = new RestRequest("/pet/{petId}/uploadImage", Method.Post);
            _request.AddUrlSegment("petId", 12345);
            _request.AddFile("file", "test-image.jpg"); // Assuming a test image in the current directory
        }

        [Given(@"I have an invalid pet ID and a valid image")]
        public void GivenIHaveAnInvalidPetIDAndAValidImage()
        {
            _request = new RestRequest("/pet/{petId}/uploadImage", Method.Post);
            _request.AddUrlSegment("petId", -1);
            _request.AddFile("file", "test-image.jpg"); // Assuming a test image in the current directory
        }

        [When(@"I upload the image for the pet")]
        public void WhenIUploadTheImageForThePet()
        {
            _response = _client.Execute(_request);
        }
    }
}
