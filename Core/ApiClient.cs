using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmployeeManagement_Windows.Core
{
    /// <summary>
    /// Singleton HttpClient wrapper for all API communication.
    /// NEVER create additional HttpClient instances — use this class exclusively.
    /// </summary>
    public static class ApiClient
    {
        private static readonly HttpClient _client = new HttpClient();

        /// <summary>
        /// The API base URL.
        /// </summary>
        public static string BaseUrl { get; set; } = "https://localhost:44325";

        static ApiClient()
        {
            // Allow self-signed certificates for localhost development
            System.Net.ServicePointManager.ServerCertificateValidationCallback += 
                (sender, cert, chain, sslPolicyErrors) => 
                {
                    if (BaseUrl.Contains("localhost")) return true;
                    return sslPolicyErrors == System.Net.Security.SslPolicyErrors.None;
                };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Initializes the base address from configuration.
        /// Call this once in Program.cs before any API calls.
        /// </summary>
        public static void Initialize(string baseUrl)
        {
            BaseUrl = baseUrl.TrimEnd('/');
        }

        /// <summary>
        /// Attaches the JWT Bearer token from SessionManager before each request.
        /// </summary>
        private static void AttachToken()
        {
            if (SessionManager.IsLoggedIn)
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.Token);
            }
            else
            {
                _client.DefaultRequestHeaders.Authorization = null;
            }
        }

        /// <summary>
        /// Sends a GET request and deserializes the JSON response.
        /// </summary>
        public static async Task<T> GetAsync<T>(string endpoint)
        {
            AttachToken();
            var response = await _client.GetAsync($"{BaseUrl}/{endpoint.TrimStart('/')}");
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException(response.StatusCode, json);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Sends a POST request with a JSON body and deserializes the response.
        /// </summary>
        public static async Task<T> PostAsync<T>(string endpoint, object data)
        {
            AttachToken();
            var content = new StringContent(
                JsonConvert.SerializeObject(data, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }),
                Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"{BaseUrl}/{endpoint.TrimStart('/')}", content);
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException(response.StatusCode, json);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Sends a POST request with a JSON body. Returns only the success/error message.
        /// </summary>
        public static async Task<ApiResponse> PostAsync(string endpoint, object data)
        {
            AttachToken();
            var content = new StringContent(
                JsonConvert.SerializeObject(data, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }),
                Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"{BaseUrl}/{endpoint.TrimStart('/')}", content);
            var json = await response.Content.ReadAsStringAsync();

            return new ApiResponse
            {
                Success = response.IsSuccessStatusCode,
                StatusCode = (int)response.StatusCode,
                Message = json
            };
        }

        /// <summary>
        /// Sends a PUT request with a JSON body.
        /// </summary>
        public static async Task<ApiResponse> PutAsync(string endpoint, object data)
        {
            AttachToken();
            var content = new StringContent(
                JsonConvert.SerializeObject(data, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }),
                Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"{BaseUrl}/{endpoint.TrimStart('/')}", content);
            var json = await response.Content.ReadAsStringAsync();

            return new ApiResponse
            {
                Success = response.IsSuccessStatusCode,
                StatusCode = (int)response.StatusCode,
                Message = json
            };
        }

        /// <summary>
        /// Sends a DELETE request.
        /// </summary>
        public static async Task<ApiResponse> DeleteAsync(string endpoint)
        {
            AttachToken();
            var response = await _client.DeleteAsync($"{BaseUrl}/{endpoint.TrimStart('/')}");
            var json = await response.Content.ReadAsStringAsync();

            return new ApiResponse
            {
                Success = response.IsSuccessStatusCode,
                StatusCode = (int)response.StatusCode,
                Message = json
            };
        }
    }

    /// <summary>
    /// Simple response wrapper for non-typed API responses.
    /// </summary>
    public class ApiResponse
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    /// <summary>
    /// Custom exception for API errors with status code context.
    /// </summary>
    public class ApiException : Exception
    {
        public System.Net.HttpStatusCode StatusCode { get; }
        public string ResponseBody { get; }

        public ApiException(System.Net.HttpStatusCode statusCode, string responseBody)
            : base($"API Error {(int)statusCode}: {responseBody}")
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
        }
    }
}
