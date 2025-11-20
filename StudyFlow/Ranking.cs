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

        public double PontuacaoPrioridade { get;  set; }
        public string NomeUserRanking { get;  set; }

        public int Posicao { get; private set; }


        public static List<Ranking> RankingGeral = new List<Ranking>();


        


        public Ranking(string nomeUserRanking, double pontuacaoPrioridade, int posicao) {

            NomeUserRanking = nomeUserRanking;
            PontuacaoPrioridade = pontuacaoPrioridade;
            Posicao = posicao;

        }

        public Ranking() {
        }








        public static void CalcularRanking() {



            //Usuario novoUsuario = new Usuario(nomeCompleto, cpf,
            //DadosDoCadastroLogin == RankingGeral

            foreach (Usuario user in Usuario.DadosDoCadastroLogin)
            {


                Ranking usuarioNoRanking = RankingGeral.FirstOrDefault(u => u.NomeUserRanking == user.NomeUser);



                if (usuarioNoRanking == null )
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





                Ranking.RankingGeral.Sort((a, b) => b.PontuacaoPrioridade.CompareTo(a.PontuacaoPrioridade));
                int posicao = 1;

                foreach (var posicaoUser in Ranking.RankingGeral)
                {




                    if (Usuario.UsuarioLogado.NomeUser == posicaoUser.NomeUserRanking)
                    {
                        Usuario.UsuarioLogado.PosiçãoRanking = posicao;

                    }

                    posicaoUser.Posicao = posicao;




                    posicao++;


                }



            }

        }








        public static void LocalizarUser() {
                    
            



        }




    }
}
