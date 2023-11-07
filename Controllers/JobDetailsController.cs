using Jobs_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;


namespace Jobs_Portal.Controllers
{
    public class JobDetailsController : Controller
    {
        
        private readonly HttpClient _httpClient;

        public JobDetailsController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://data.cityofnewyork.us/resource/kpav-sd4t.json");
        }

        public async Task<IActionResult> Index(string jobID)
        {
            try
            {
                // Fetch all job postings
                HttpResponseMessage response = await _httpClient.GetAsync(string.Empty);

                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the JSON response into a list of JobDetails
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var jobDetailsList = JsonSerializer.Deserialize<List<JobDetails>>(jsonContent);

                    // Filter the job details by job ID
                    var selectedJob = jobDetailsList.FirstOrDefault(job => job.job_id == jobID);

                    if (selectedJob != null)
                    {
                        return View(selectedJob); // Pass the selected job to the view
                    }
                    else
                    {
                        // Handle the case where the job with the specified ID is not found
                        return View("Error");
                    }
                }
                else
                {
                    // Handle the API request error
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                return View("Error");
            }
        }

    }
}
