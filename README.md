# 🎮 Jokenpô — C# Windows Forms

Um jogo de **Jokenpô (Pedra, Papel e Tesoura)** desenvolvido em **C# com Windows Forms**.

O projeto utiliza a classe `Random` para gerar a escolha da máquina e possui um sistema de partidas, pontuação e vitórias.

## 🕹️ Como funciona

O jogador escolhe uma das três opções:

* 🪨 **Pedra**
* 📄 **Papel**
* ✂️ **Tesoura**

A máquina realiza uma escolha aleatória utilizando `Random`.

Depois da rodada, o programa compara as escolhas e informa o resultado:

* 🟢 **Você ganhou!**
* 🔴 **Você perdeu!**
* 🟡 **Empate!**

Após realizar uma jogada, os botões de escolha são desabilitados para impedir que o jogador faça mais de uma escolha na mesma rodada. O botão **Limpar** permite iniciar uma nova rodada.

## 🏆 Sistema de pontuação

A partida funciona no formato **melhor de 5**, ou seja, o primeiro jogador a alcançar **3 pontos** vence.

Ao atingir 3 pontos:

* Uma mensagem informa o vencedor da partida.
* A pontuação da rodada é zerada.
* Uma vitória é adicionada ao placar geral.
* Uma nova partida pode ser iniciada.

O programa mantém separadamente:

* 🧑 **Pontuação do usuário**
* 🤖 **Pontuação da máquina**
* 🏆 **Vitórias do usuário**
* 🏆 **Vitórias da máquina**

## 🔄 Funcionalidades

* 🎮 Escolha entre Pedra, Papel e Tesoura
* 🤖 Jogada aleatória da máquina
* 🎲 Utilização da classe `Random`
* 🏆 Sistema de pontuação
* 🥇 Partidas até 3 pontos
* 📊 Contador de vitórias
* 🔒 Bloqueio dos botões após uma jogada
* 🧹 Botão para limpar a rodada
* 🔄 Botão para reiniciar o jogo
* 🗑️ Botão para zerar a pontuação da rodada
* ❓ Confirmação antes de reiniciar ou zerar
* 🎨 Cores diferentes para vitória, derrota e empate
* 🚪 Botão para sair do jogo

## 🛠️ Tecnologias utilizadas

* **C#**
* **Windows Forms**
* **.NET Framework**
* **Visual Studio**

## 📚 Conceitos praticados

Este projeto foi desenvolvido para praticar conceitos fundamentais de programação em C# e Windows Forms, incluindo:

* Variáveis
* Tipos de dados
* `if`, `else if` e `else`
* Operadores condicionais
* `Random`
* Métodos
* Eventos de botões (`Click`)
* `int.Parse()`
* `.ToString()`
* Propriedade `Enabled`
* Propriedade `ForeColor`
* `MessageBox`
* `DialogResult`
* `try/catch`
* Manipulação de componentes do Windows Forms
* Controle de fluxo
* Sistema de pontuação

## 💬 MessageBox

O projeto também utiliza caixas de diálogo para solicitar confirmação ao jogador antes de determinadas ações.

Exemplo:

```csharp
DialogResult result = MessageBox.Show(
    "As pontuações serão zeradas, você tem certeza?",
    "Reiniciar Jogo",
    MessageBoxButtons.YesNo
);

if (result == DialogResult.Yes)
{
    // Reinicia as pontuações
}
```

## 🎯 Objetivo do projeto

O objetivo principal foi desenvolver um projeto simples e interativo para praticar **lógica de programação em C#**, utilizando uma interface gráfica construída com **Windows Forms**.

O projeto também serviu para praticar a criação de métodos, manipulação de componentes, eventos de interface e utilização de valores aleatórios.

## 👨‍💻 Autor

**Otávio Augusto**

Projeto desenvolvido para estudos de **C# e Windows Forms**.
