using System;
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
        [JsonPropertyName("ID")] public string ID {  get; set; }
        [JsonPropertyName("Tipo")] public string Tipo { get; set; }
        [JsonPropertyName("Pontuacao")] public double Pontuacao {  get; set; }
        [JsonPropertyName("Tema")] public string Tema {  get; set; }
        [JsonPropertyName("Area")] public string Area {  get; set; }
        [JsonPropertyName("Enunciado")] public string Enunciado {  get; set; }
        [JsonPropertyName("A")] public string A {  get; set; }
        [JsonPropertyName("B")] public string B {  get; set; }
        [JsonPropertyName("C")] public string C {  get; set; }
        [JsonPropertyName("D")] public string D {  get; set; }
        [JsonPropertyName("E")] public string E {  get; set; }
        [JsonPropertyName("Resposta")] public string? Resposta { get; set; }
        [JsonPropertyName("PontuacaoParcial")] public double PontuacaoParcial { get; set; }


        public double Erros {  get; set; }
        
        public static double CorrecaoPontos(Pergunta pergunta)
        {

            if (pergunta.Erros == 1)
            {

                pergunta.PontuacaoParcial = pergunta.Pontuacao * 0.66;
                return pergunta.PontuacaoParcial;
            }

            else if (pergunta.Erros == 2)
            {
                pergunta.PontuacaoParcial = pergunta.Pontuacao * 0.33;
                return pergunta.PontuacaoParcial;
            }

            else
            {
                pergunta.PontuacaoParcial = 0;
                return pergunta.PontuacaoParcial;
            }
        }
        public static void ChecarResposta(string respostaDada, Pergunta pergunta, Usuario usuario)
        {
            if (respostaDada != pergunta.Resposta)
            {
                pergunta.Erros++;
                CorrecaoPontos(pergunta);
            }

            else if (respostaDada == pergunta.Resposta)
            {
                //tela pra aparecer que acertou a pergunta
                usuario.Pontuacao += pergunta.PontuacaoParcial;
            }
        }


    }
}
