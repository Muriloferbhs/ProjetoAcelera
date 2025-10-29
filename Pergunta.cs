using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace StudyFlow
{
    internal class Pergunta
    {
        [JsonPropertyName("ID")] public string ID {  get; set; }
        [JsonPropertyName("Tipo")] public string Tipo { get; set; }
        [JsonPropertyName("Pontuacao")] public int Pontuacao {  get; set; }
        [JsonPropertyName("Tema")] public string Tema {  get; set; }
        [JsonPropertyName("Area")] public string Area {  get; set; }
        [JsonPropertyName("Enunciado")] public string Enunciado {  get; set; }
        [JsonPropertyName("A")] public string A {  get; set; }
        [JsonPropertyName("B")] public string B {  get; set; }
        [JsonPropertyName("C")] public string C {  get; set; }
        [JsonPropertyName("D")] public string D {  get; set; }
        [JsonPropertyName("E")] public string E {  get; set; }
        [JsonPropertyName("Resposta")] public string Resposta {  get; set; }

        
    }
}
