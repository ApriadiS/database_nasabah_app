using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DatabaseNasabah.Models
{
    public class PublicKey
    {
        public string public_key { get; set; }
    }

    public class Packet
    {
        public string Data { get; set; }
        public string Timestamp { get; set; }
        public string Public_Key { get; set; }
    }

    public class URL
    {
        public string Method { get; set; }
        public string Domain { get; set; }

        public URL(string method, string domain)
        {
            Method = method;
            Domain = domain;
        }

        public string getURL(string[] path)
        {
            string url = Method + "://" + Domain;
            if (path.Length > 0)
            {
                foreach (string p in path)
                {
                    url += "/" + p;
                }
            }
            return url;
        }
    }

    public class ServerService
    {
        private readonly HttpClient httpClient;
        private PublicKey key;
        private readonly URL url;

        public ServerService(URL url)
        {
            httpClient = new HttpClient();
            this.url = url;
        }

        public async Task<string> GetPublicKeyAsync()
        {
            try
            {
                // menerima public key dari server dalam bentuk json
                var response = await httpClient.GetAsync(
                    this.url.getURL(new string[] { "get", "public_key" })
                );
                var publicKeyJson = await response.Content.ReadAsStringAsync();
                // ambil public key sebagai string dari json
                key = JsonSerializer.Deserialize<PublicKey>(publicKeyJson);
                return key.public_key;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to get public key from server {e.Message}");
            }
        }

        public async Task<string> GetDataAsync()
        {
            var response = await httpClient.GetAsync("https://www.example.com/api/data");
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public async Task PostDataAsync(string data)
        {
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://www.example.com/api/data", content);
        }
    }
}
