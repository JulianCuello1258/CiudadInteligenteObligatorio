using System.Net.Http.Headers;
using System.Net.Http.Json;
using CiudadInteligenteObligatorio.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace CiudadInteligenteObligatorio.Service
{
    public class ReporteApiService
    {
        private readonly HttpClient _http;

        public ReporteApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<PaginaResultado<Reporte>> GetAllAsync(FiltroReportes filtro)
        {
            var url = $"api/reportes?pagina={filtro.Pagina}&tamanio={filtro.Tamanio}";
            if (filtro.CategoriaId.HasValue)
                url += $"&categoriaId={filtro.CategoriaId.Value}";
            if(!string.IsNullOrWhiteSpace(filtro.Barrio))
                url += $"&barrio={filtro.Barrio}";
            if(!string.IsNullOrWhiteSpace(filtro.Estado))
                url += $"&estado={filtro.Estado}";
            if (!string.IsNullOrWhiteSpace(filtro.Prioridad))
                url += $"&prioridad={filtro.Prioridad}";
            if (filtro.FechaDesde.HasValue)
                url += $"&fechaDesde={filtro.FechaDesde.Value:yyyy-MM-dd}";
            if (filtro.FechaHasta.HasValue)
                url += $"&fechaHasta={filtro.FechaHasta.Value:yyyy-MM-dd}";
            var resultado = await _http.GetFromJsonAsync<PaginaResultado<Reporte>>(url);
            return resultado ?? new PaginaResultado<Reporte>();
        }

        public async Task<Reporte?> GetByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<Reporte>($"api/reportes/{id}");
        }

        public async Task<Reporte> CreateAsync(ReporteCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/reportes", dto);
            response.EnsureSuccessStatusCode();
            return (await response.Content.ReadFromJsonAsync<Reporte>())!;
        }

        public async Task UploadFotosAsync(int id, IBrowserFile imagen)
        {
            using var content = new MultipartFormDataContent();
            var archivo = new StreamContent(imagen.OpenReadStream(maxAllowedSize: 5 * 1024 * 1024)); // 5 MB
            archivo.Headers.ContentType = new MediaTypeHeaderValue(imagen.ContentType);
            content.Add(archivo, "fotos", imagen.Name);

            var response = await _http.PostAsync($"api/reportes/{id}/fotos", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task CambiarEstadoAsync(int id, CambioEstadoDto dto)
        {
            var response = await _http.PatchAsJsonAsync($"api/reportes/{id}/estado", dto);
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<Categoria>> GetCategoriasAsync()
        {
            var categorias = await _http.GetFromJsonAsync<List<Categoria>>("api/categorias");
            return categorias ?? new List<Categoria>();
        }

        public async Task<List<Barrio>> GetBarriosAsync()
        {
            var barrios = await _http.GetFromJsonAsync<List<Barrio>>("api/barrios");
            return barrios ?? new List<Barrio>();
        }
    }
}
