using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Translation.Web.Interfaces;
using Translation.Web.Models.Entities;

namespace Translation.Web.Repository
{
    public class TranslationRepository : ITranslationRequestRepository
    {
         private readonly HttpClient _httpClient;
    private const string FunTranslationsApiEndpoint = "https://api.funtranslations.com/translate/";

    public TranslationRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> TranslateToLeetSpeak(string text)
    {
        var translationRequest = new TranslationRequest { text = text };
        using System.Text.Json;

        // ...

        var jsonRequest = JsonSerializer.Serialize(translationRequest, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // ...
    }
    }
}
