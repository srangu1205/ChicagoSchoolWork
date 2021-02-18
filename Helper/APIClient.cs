using ChicagoSchoolsAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace ChicagoSchoolsAPI.Helper
{
    public class APIClient
    {
        public static async Task<Root> GetSchoolInfoAsync(string schoolId)
        {
            var schools = new Root();
            try
            {
                string url = "https://api.cps.edu/schoolprofile/CPS/SchoolComparison?SchoolIDs=" + schoolId;  //Todo move to web.config

                // string url = "https://api.cps.edu/SchoolProfile/CPS/AllSchoolProfiles";
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(url);
                    //HTTP GET
                    var responseTask = client.GetAsync("school");
                    responseTask.Wait();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

                    var responseMessage = client.GetAsync(url).Result;
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(responseData);
                        string jsonText = JsonConvert.SerializeXmlNode(doc);
                        schools = JsonConvert.DeserializeObject<Root>(jsonText);
                    }
                }
            }

            catch (Exception ex)
            {
                //Log exception
                var msg = ex.Message;
            }
            return schools;
        }

        public static List<SchoolPercentageResults> GetStudentPercentages()
        {
            var schoolInfo = APIClient.GetSchoolInfoAsync("609720,609755,609724").Result;
            var viewModel = new List<SchoolPercentageResults>();
            try
            {
                foreach (var item in schoolInfo.ArrayOfSchoolProfile.SchoolProfile)
                {
                    viewModel.Add(new SchoolPercentageResults
                    {
                        SchoolId = item.SchoolID,
                        SchoolShortName = item.SchoolShortName,
                        StudentCountBlack = CalculatePercentage(item.StudentCountBlack, item),
                        StudentCountHispanic = CalculatePercentage(item.StudentCountHispanic, item),
                        StudentCountWhite = CalculatePercentage(item.StudentCountWhite, item),
                        StudentCountAsian = CalculatePercentage(item.StudentCountAsian, item),
                        StudentCountNativeAmerican = CalculatePercentage(item.StudentCountNativeAmerican, item),
                        StudentCountAsianPacificIslander = CalculatePercentage(item.StudentCountAsianPacificIslander, item),
                        StudentCountMultiEthnic = CalculatePercentage(item.StudentCountMultiEthnic, item),
                        StudentCountHawaiianPacificIslander = CalculatePercentage(item.StudentCountHawaiianPacificIslander, item),
                        StudentCountEthnicityOther = CalculatePercentage(item.StudentCountEthnicityOther, item),
                        StudentCountEthnicityUnavailable = CalculatePercentage(item.StudentCountEthnicityUnavailable, item),

                    }
                    ); ;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
            }
            return viewModel;
        }

        public static double CalculatePercentage(string input, SchoolProfile item)
        {

            var result = (double)Convert.ToInt32(input) * 100 / (double)Convert.ToInt32(item.StudentCount);
            return result;
        }

       
    }
}