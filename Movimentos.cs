using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Movimentos : Acao
    {
        public Movimentos(int tamLinhas, int tamColunas) {
            construtorTabuleiro(tamLinhas, tamColunas);
        }

        public void movimentacaoPlayer(ConsoleKey escolhaMovimento)
        {
            bool movimentoValido;// = true;
            switch (escolhaMovimento) {
                case ConsoleKey.RightArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento);
                    if(movimentoValido) movimentoValido = verificarMovimentoPerto(escolhaMovimento);
                    if(movimentoValido) {
                        for (int i = 0; i < tamLinhas; i++){
                            for (int j = 0; j < tamColunas; j++) {
                                if(posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i, j + 1] = true;
                                    return;
                                }
                            }
                        }
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento);
                    if (movimentoValido) movimentoValido = verificarMovimentoPerto(escolhaMovimento);
                    if (movimentoValido) {
                        for (int i = 0; i < tamLinhas; i++) {
                            for (int j = 0; j < tamColunas; j++) {
                                if (posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i, j - 1] = true;
                                    return;
                                }
                            }
                        }
                    }
                    break;

                case ConsoleKey.UpArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento);
                    if (movimentoValido) movimentoValido = verificarMovimentoPerto(escolhaMovimento);
                    if (movimentoValido) {
                        for (int i = 0; i < tamLinhas; i++) {
                            for (int j = 0; j < tamColunas; j++) {
                                if (posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i - 1, j] = true;
                                    return;
                                }
                            }
                        }
                    }
                    break;

                case ConsoleKey.DownArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento);
                    if (movimentoValido) movimentoValido = verificarMovimentoPerto(escolhaMovimento);
                    if (movimentoValido) {
                        for (int i = 0; i < tamLinhas; i++) {
                            for (int j = 0; j < tamColunas; j++) {
                                if (posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i + 1, j] = true;
                                    return;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private bool verificarMovimento(ConsoleKey escolhaMovimento)
        {
            for(int i = 0; i < tamLinhas; i++) {
                for(int j = 0; j < tamColunas; j++) {
                    if(i == 0 && escolhaMovimento == ConsoleKey.UpArrow && posicaoJogador[i, j] == true) {
                        return false;
                    }
                    else if(j == 0 && escolhaMovimento == ConsoleKey.LeftArrow && posicaoJogador[i,j] == true) {
                        return false;
                    }
                    else if(i == tamLinhas - 1 && escolhaMovimento == ConsoleKey.DownArrow && posicaoJogador[i,j] == true) {
                        return false;
                    }
                    else if(j == tamColunas-1 && escolhaMovimento == ConsoleKey.RightArrow && posicaoJogador[i,j] == true) {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool verificarMovimentoPerto(ConsoleKey escolhaMovimento)
        {
            for (int i = 0; i < tamLinhas; i++) {
                for (int j = 0; j < tamColunas; j++) {
                    switch (escolhaMovimento) {
                        case ConsoleKey.LeftArrow:
                            if (tabuleiroCompleto[i, tamColunas - 1] == "  ") {
                                if (posicaoJogador[i, tamColunas - 1]) return true;
                                return false;
                            }
                            else if (tabuleiroCompleto[i, j] == "  ") {
                                if (posicaoJogador[i, j] || posicaoJogador[i, j + 1]) return true;
                                return false;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if(tabuleiroCompleto[i, 0] == "  ") {
                                if (posicaoJogador[i, 0]) return true;
                                return false;
                            }
                            else if(tabuleiroCompleto[i, j] == "  ") {
                                if (posicaoJogador[i, j] || posicaoJogador[i, j - 1]) return true;
                                return false;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (tabuleiroCompleto[tamLinhas - 1, j] == "  ") {
                                if (posicaoJogador[tamLinhas - 1, j]) return true;
                                return false;
                            }
                            else if (tabuleiroCompleto[i, j] == "  ") {
                                if (posicaoJogador[i, j] || posicaoJogador[i + 1, j]) return true;
                                return false;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if(tabuleiroCompleto[0, j] == "  ") {
                                if (posicaoJogador[0, j]) return true;
                                return false;
                            }
                            else if(tabuleiroCompleto[i, j] == "  ") {
                                if (posicaoJogador[i, j] || posicaoJogador[i - 1, j]) return true;
                                return false;
                            }
                            break;
                    }
                }
            }
            return true;
        }
    }
}