using Microsoft.VisualBasic.ApplicationServices;
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
      


        public static List<Ranking> RankingGeral = new List<Ranking>();


        //Ranking.CalcularRanking(usuariologado.NomeUser, usuariologado.Pontuacao, usuariologado.Ativo);


        public Ranking(string nomeUserlogado, double pontuacaoUserlogado) {

            NomeUserRanking = nomeUserlogado;
            PontuacaoPrioridade = pontuacaoUserlogado;
           

        }

        public Ranking() {
        }








        public static void CalcularRanking() {



            //Usuario novoUsuario = new Usuario(nomeCompleto, cpf,
            //DadosDoCadastroLogin == RankingGeral

            foreach (Usuario user in Usuario.DadosDoCadastroLogin)
            {


                Ranking usuarioNoRanking = RankingGeral.FirstOrDefault(u => u.NomeUserRanking == user.NomeUser);



                if (usuarioNoRanking == null)
                {
                    RankingGeral.Add(new Ranking
                    {
                        NomeUserRanking = user.NomeUser,
                        PontuacaoPrioridade = user.Pontuacao
                    });

                }
                else
                {
                    usuarioNoRanking.PontuacaoPrioridade = user.Pontuacao;
                }
                




            }

        }








        public void CalcularRanking(string senha) {





        }




    }
}
