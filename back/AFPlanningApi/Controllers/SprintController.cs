using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using AFPlanningApi.domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AFPlanningApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SprintController
        : ControllerBase
    {
        private readonly ILogger<SprintController> _logger;
        public SprintController(ILogger<SprintController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/organization")]
        public IActionResult GetProjects()

        {
            var token = System.IO.File.ReadAllText(@"Token.txt");
            var orgName = "Alfa-Projects-Ronaldo";

            string credentials = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", token)));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://dev.azure.com/{orgName}/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                HttpResponseMessage response = client.GetAsync("_apis/projects?stateFilter=All&api-version=1.0").Result;

                if (response.IsSuccessStatusCode)
                {
                    //set the viewmodel from the content in the response
                    //viewModel = response.Content.ReadAsAsync<ListOfProjectsResponse.Projects>().Result;
                    //teste

                    var value = response.Content.ReadAsStringAsync().Result;
                }

            }

            return Ok(new Sprint());
        }


        [HttpGet]
        public IActionResult GetSprints()
        {
            var project = "Registro de apontamentos";
            var team = "Registro de apontamentos Team";
            var token = System.IO.File.ReadAllText(@"Token.txt");
            var orgName = "Alfa-Projects-Ronaldo";
            string credentials = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", token)));

            //GET https://dev.azure.com/{organization}/{project}/{team}/_apis/work/teamsettings/iterations?api-version=6.0



            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://dev.azure.com/{orgName}/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                HttpResponseMessage response = client.GetAsync($"{project}/{team}/_apis/work/teamsettings/iterations?api-version=6.0").Result;

                if (response.IsSuccessStatusCode)
                {
                    //set the viewmodel from the content in the response
                    //viewModel = response.Content.ReadAsAsync<ListOfProjectsResponse.Projects>().Result;
                    //teste

                    var json = response.Content.ReadAsStringAsync().Result;
                    var sprints = JsonConvert.DeserializeObject<SprintAzureResponse>(json);

                    return Ok(sprints.Value);

                }

            }

            return Ok(new Sprint());

        }


        [HttpGet]
        [Route("byUrl")]
        public IActionResult GetSprint([FromQuery]string url)
        {
            // https://localhost:5001/sprint/byUrl?url=https://dev.azure.com/Alfa-Projects-Ronaldo/32d4cbca-6a87-4116-bc78-36618ae22421/acbc19a0-4bde-4c66-b24c-731db502e061/_apis/work/teamsettings/iterations/b0caf3a2-e2eb-4783-ad37-cbc1bfa7ec99
            
            var project = "Registro de apontamentos";
            var team = "Registro de apontamentos Team";
            var token = System.IO.File.ReadAllText(@"Token.txt");
            var orgName = "Alfa-Projects-Ronaldo";
            string credentials = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", token)));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://dev.azure.com/{orgName}/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
                
                var tmp = url.Split('/');
                var hash1 = tmp[4];
                var hash2 = tmp[5];
                var sprintId = tmp.Last();

                HttpResponseMessage response = client.GetAsync($"{hash1}/{hash2}/_apis/work/teamsettings/iterations/{sprintId}").Result;

                // {hash1}/{hash2}}/_apis/work/teamsettings/iterations/{sprintId}}
                if (response.IsSuccessStatusCode)
                {
                    //set the viewmodel from the content in the response
                    //viewModel = response.Content.ReadAsAsync<ListOfProjectsResponse.Projects>().Result;
                    //teste

                    var content = response.Content.ReadAsStringAsync().Result;
                    return Ok(content);
                }

            }

            return Ok(new Sprint());

        }


    }
}
