using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient apiClient;

        public TransferService(HttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "http://localhost:60114/api/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDTO),
                                            System.Text.Encoding.UTF8, "application/json");
            
            var response = await apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
