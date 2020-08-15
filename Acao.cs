using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Acao : Tabuleiro
    {
        public void mudarPosicao()
        {
            string aux;
            for (int i = 0; i < tamLinhas; i++) {
                for (int j = 0; j < tamColunas; j++) {
                    if (posicaoJogador[i, j] && tabuleiroCompleto[i, j] == "  ") {
                        return;
                    }
                    else if(posicaoJogador[i,j]){
                        //ij[0] = i;     ij[1] = j;
                        short[] ij = new short[2];
                        ij = Ij();
                        aux = tabuleiroCompleto[i, j];
                        tabuleiroCompleto[i, j] = "  ";
                        tabuleiroCompleto[ij[0], ij[1]] = aux;
                    }
                }
            }
            
        }

        private short[] Ij()
        {
            short[] ij = new short[2];
            for(int i = 0; i < tamLinhas; i++) {
                for(int j = 0; j < tamColunas; j++) {
                    if(tabuleiroCompleto[i,j] == "  ") {
                        ij[0] = (short)i;
                        ij[1] = (short)j;
                    }
                }
            }
            return ij;
        }
    }
}