using System.Net.Http.Headers;
using System.Text.Json;
using ZiurApp.Shared.Models;

namespace ZiurApp.Client.Services
{
    public class DocumentoService
    {
        private readonly HttpClient _http;
        private const string _token = "ae8bad44-7348-11ee-b962-0242ac120002";
        private const string _url = "https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/api/DocumentosFillsCombos";

        public DocumentoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Documento>> ObtenerDocumentosAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            return JsonSerializer.Deserialize<List<Documento>>(json, opciones) ?? new();
        }
    }
}
