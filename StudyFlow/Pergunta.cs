using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudyFlow
{
    public class Pergunta
    {
        [JsonPropertyName("ID")] public string ID { get; set; }
        [JsonPropertyName("Tipo")] public string Tipo { get; set; }
        [JsonPropertyName("Pontuacao")] public double Pontuacao { get; set; }
        [JsonPropertyName("Tema")] public string Tema { get; set; }
        [JsonPropertyName("Area")] public string Area { get; set; }
        [JsonPropertyName("Enunciado")] public string Enunciado { get; set; }
        [JsonPropertyName("A")] public string A { get; set; }
        [JsonPropertyName("B")] public string B { get; set; }
        [JsonPropertyName("C")] public string C { get; set; }
        [JsonPropertyName("D")] public string D { get; set; }
        [JsonPropertyName("E")] public string E { get; set; }
        [JsonPropertyName("Resposta")] public string? Resposta { get; set; }
        [JsonPropertyName("PontuacaoParcial")] public double PontuacaoParcial { get; set; }

        [JsonPropertyName("expA")] public string expA { get; set; }
        [JsonPropertyName("expB")] public string expB { get; set; }
        [JsonPropertyName("expC")] public string expC { get; set; }
        [JsonPropertyName("expD")] public string expD { get; set; }
        [JsonPropertyName("expE")] public string expE { get; set; }
        [JsonPropertyName("expUnica")] public string expUnica { get; set; }
        public bool Respondida { get; set; } = false;


        public double Erros { get; set; }

    }
}
