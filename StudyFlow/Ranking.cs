using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace StudyFlow {
    internal class Ranking {

        public double PontuacaoPrioridade { get; private set; }
        public string NomeUserRanking { get; private set; }
        public bool AtivoRanking { get; private set; }


        public static List<Ranking> RankingGeral = new List<Ranking>();





        public Ranking(string nomeUserlogado, double pontuacaoUserlogado, bool ativoRanking) {

            NomeUserRanking = nomeUserlogado;
            PontuacaoPrioridade = pontuacaoUserlogado;
            AtivoRanking = ativoRanking;

        }

        public Ranking() {
        }








        public static void CalcularRanking(string nomeUserlogado, double pontuacaoUser, bool ativoUser) {



            //Usuario novoUsuario = new Usuario(nomeCompleto, cpf,


            Ranking u;
            Ranking usuarioExistente = RankingGeral.FirstOrDefault(u => u.NomeUserRanking == nomeUserlogado);



            if (usuarioExistente == null)
            {
                Ranking newUserRanking = new Ranking(nomeUserlogado, pontuacaoUser, ativoUser);
                Ranking.RankingGeral.Add(newUserRanking);

            }


            RankingGeral.Sort((a, b) => b.PontuacaoPrioridade.CompareTo(a.PontuacaoPrioridade));








            foreach (var Ranking in RankingGeral)
            {
                Console.WriteLine($"{Ranking.NomeUserRanking} {Ranking.AtivoRanking} (Priority: {Ranking.PontuacaoPrioridade})");
            }




        }








        public void CalcularRanking(string senha) {





        }




    }
}
