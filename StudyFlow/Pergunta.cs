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
        public bool Respondida { get; set; } = false;

        public static Dictionary<string, bool> QuestoesRespondidas { get; } = new Dictionary<string, bool>();

        public static void MarcarComoRespondida(string id)
        {
            if (!QuestoesRespondidas.ContainsKey(id))
                QuestoesRespondidas[id] = true;
        }

        public static bool JaRespondeu(string id)
        {
            return QuestoesRespondidas.ContainsKey(id) && QuestoesRespondidas[id];
        }

        public double Erros { get; set; }

    }
}
