# cs-lotofacil

## Português (Brasil)

Em outubro de 2015 meu irmão e alguns amigos decidiram apostar regularmente na Lotofácil e me convidaram a participar de um bolão semanal. A Lotofácil é um jogo lotérico onde aposta-se de 15 a 18 números em um total de 25 números disponíveis e ganha-se um prêmio à partir de 11 acertos; quanto mais números acertados, melhor. Como o próprio nome diz as chances de ganhar são relativamente altas, em relação às outras loterias disponíveis no Brasil.

Sei que o jogo é baseado em probabilidades, no entanto alguns jogos parecem um tanto quanto impossíveis de acontecer, como por exemplo um jogo completamente sequencial, como por exemplo "01-02-03-04-05-06-07-08-09-10-11-12-13-14-15" ou "02-03-04-05-06-07-08-09-10-11-12-13-14-15-16", assim como é um tanto quanto improvável acontecer um jogo com 10 intervalos em sequência, como por exemplo "01-02-12-13-14-15-16-17-18-19-20-21-22-23-24" ou "01-12-13-14-15-16-17-18-19-20-21-22-23-24-25". Com esse pensamento em mente pus-me a pesquisar na internet diversas teorias e "técnicas" para podermos criar jogos com maiores chances de acertar 11 ou mais números.

O resultado da rápida pesquisa que eu fiz me levou a criar este programa que, em resumo, pode realizar uma análise de todos os jogos já sorteados para então apresentar o resultado dessa análise ao usuário, quanto pode gerar números com base em regras pré-estabelecidas, o que será explicado mais à frente.

Este programa é livre para uso de qualquer pessoa. Sinta-se à vontade para baixar o código-fonte e realizar quaisquer mudanças que achar necessárias. Caso ache que algum melhoramento pode ser feito entre em contato, caso você mesmo tenha feito alguma melhoria peço a gentileza de compartilhar com a comunidade, como fiz neste trabalho inicial.

### Estrutura do projeto

O projeto possui 3 pastas:

* **init:** nesta pasta estão disponíveis o arquivo gerado pela Caixa Econômica Federal (D_lotfac.zip) contendo todos os resultados da Lotofácil até o dia 02/10/2015 e o arquivo "base.txt" que consiste em uma extração textual pura das informações contidas no arquivo anterior. O processo de extração dessa informação foi feito de maneira puramente manual.
* **analysis:** nesta pasta está contida uma análise de resultados prévios realizada em novembro de 2015. A análise consiste em avaliar 6 aspectos de cada jogo e será explicada posteriormente.
* **Lotofacil:** código-fonte do projeto

### Análise dos jogos

O programa permite realizar uma análise de todos os jogos que já foram sorteados anteriormente. Importante que essa análise serve apenas como base para que o usuário possa decidir quais regras ele usará para criar seus jogos posteriormente. Para que a análise ocorra é necessário que o arquivo "base.txt" esteja na mesma pasta que o executável do programa. Um exemplo de como deve estar o arquivo "base.txt" pode ser encontrado na pasta "init" do projeto.

A análise verifica 6 pontos para cada jogo anterior já realizado. Cada ponto será explicado abaixo. São eles:

1. **Maior sequência de números por jogo**
   Essa parte da análise verifica qual foi a maior sequência de números para cada jogo e informa quantos jogos, em número absoluto e percentual, tiveram aquele perfil.  
```
3 números seguidos: 152 jogos (11,93%)
4 números seguidos: 388 jogos (30,46%)
7 números seguidos: 89 jogos (6,99%)
6 números seguidos: 209 jogos (16,41%)
5 números seguidos: 367 jogos (28,81%)
```
2. **Estilo das sequências de cada jogo**
   A análise do estilo das sequências considera a maneira como as sequências de números se repetem para cada jogo e diz em quantos jogos aquele estilo de sequências se repetiu em números absolutos e percentuais.  
```
2B 2B 3B 2B 1B 1B 1B 3B: 1 jogos (0,08%)
1B 4B 1B 3B 2B 2B 2B: 2 jogos (0,16%)
1B 1B 7B 1B 2B 1B 2B: 1 jogos (0,08%)
2B 2B 1B 1B 2B 4B 3B: 1 jogos (0,08%)
2B 1B 2B 3B 2B 2B 3B: 1 jogos (0,08%)
```
   Onde "2B 2B 3B 2B 1B 1B 1B 3B" indica que o jogo foi formado por: 2 números seguidos, um intervalo, 2 números seguidos, um intervalo, 3 números seguidos, um intervalo... etc.  

3. **Maior intervalo entre números por jogo**
    Essa parte da análise verifica qual foi a maior sequência de números **não sorteados** para cada jogo e informa quantos jogos, em número absoluto e percentual, tiveram aquele perfil.  
```
3 números: 440 jogos (34,54%)
4 números: 501 jogos (39,32%)
5 números: 228 jogos (17,90%)
7 números: 18 jogos (1,41%)
2 números: 17 jogos (1,33%)
```

4. **Estilo de sequências e intervalos (estilo completo)**
   Semelhante à análise de estilo de sequências, essa é uma análise completa pois ela verifica quantos números houve de intervalo entre uma sequência e outra, quantos jogos em número absoluto e percentual tiveram aquele perfil.  
```
2B 2I 2B 3I 3B 2I 2B 2I 1B 2I 1B 2I 1B 3I 3B: 1 jogos (0,08%)
1B 3I 4B 2I 1B 2I 3B 2I 2B 3I 2B 3I 2B: 1 jogos (0,08%)
1B 3I 1B 2I 7B 2I 1B 2I 2B 3I 1B 3I 2B: 1 jogos (0,08%)
2B 2I 2B 3I 1B 2I 1B 2I 2B 3I 4B 4I 3B: 1 jogos (0,08%)
2B 2I 1B 4I 2B 2I 3B 2I 2B 3I 2B 3I 3B: 1 jogos (0,08%)
```
   Onde "2B 2I 2B 3I 3B 2I 2B 2I 1B 2I 1B 2I 1B 3I 3B" indica que o jogo foi formado por: 2 números seguidos, um intervalo de 2 números, 2 números seguidos, um intervalo de 3 números, 3 números seguidos, um intervalo de 2 números... etc.  

5. **Análise de ímpares e pares**
   Análise da quantidade de números ímpares e pares por jogo já sorteado.  
```
8P7I: 339 jogos (26,61%)
6P9I: 258 jogos (20,25%)
9P6I: 143 jogos (11,22%)
7P8I: 396 jogos (31,08%)
5P10I: 86 jogos (6,75%)
```
   Onde "8P" indica 8 números pares e "7I" indica 7 números ímpares. A análise informa a quantidade de jogos em que esse estilo de jogo ocorreu tanto em números absolutos quanto em percentual.  

6. **Análise de estilo ímpar/par**
   Essa parte da análise verifica qual o estilo de cada jogo sorteado de acordo com a distribuiçãode números pares e ímpares.  
```
PIIPIPIIPPPPIPI: 1 jogos (0,08%)
IPIPIIIPIIPIPIP: 1 jogos (0,08%)
IPPIPIPIPPPIPIP: 2 jogos (0,16%)
IPPIPPPIPIPIIPI: 3 jogos (0,24%)
IPPPIIPIIPIPIPI: 2 jogos (0,16%)
```
   Onde P indica um número par e I indica um número ímpar.

### Geração de jogos

O programa conta com um módulo para geração de jogos. Os jogos são gerados e validados de acordo com algumas regras fixas e outras regras pré-estabelecidas pelo usuário.

Os jogos são gerados da seguinte maneira:

1. Sorteia-se um número qualquer de 1 a 25.
2. Verifica-se se o jogo atual já tem esse número:
   1. Se o número não existir no jogo atual o número é adicionado e segue-se para o passo 3.
   2. Se o número existir ele é descartado e retorna-se ao passo 1.
3. Verifica-se se o jogo atual já possui a quantidade de números desejada:
   1. Se já possuir a quantidade de números prossiga para o passo 4.
   2. Senão retorna para o passo 1
4. Validação do jogo de acordo com as regras fixas e as regras pré-estabelecidas pelo usuário:
   1. Se o jogo passar pela validação prossegue-se para o passo 5.
   2. Senão o jogo é descartado e retorna-se ao passo 1.
5. O jogo é retornado para o usuário e encerra-se a sua geração.

#### Regras fixas

As seguintes regras são fixas e fazem com que um jogo gerado aleatoriamente seja descartado:

1. **Jogo já existente**
   Se o jogo gerado pelo programa já tiver sido sorteado ele é automaticamente descartado. Desde a criação da Lotofácil até outubro de 2015 **NUNCA** um jogo se repetiu. Portanto as chances de que isso aconteça são extremamente remotas, assim sendo jogos repetidos são descartados.  
2. **Estilo de sequência repetido**
   Se algum dos jogos já sorteados possuir estilo de sequências igual ao jogo atual (Ex.: 2B3B1B4B) o jogo é descartado. Embora possam ocorrer estilos de sequência repetidos, eles não ocorrem mais do que 2 vezes, ou seja, é raríssimo um jogo ser sorteado com estilo de sequências igual ao de um previamente sorteado.  
3. **Estilo ímpar/par**
   O jogo é descartado quando seu estilo ímpar/par (Ex.: IPIPIPIPIIIIPPP) já foi sorteado anteriormente. À época eu acreditava que pouquíssimos jogos possuíam o mesmo estilo ímpar/par ou que ele que ele se repetia raramente. Hoje enquanto escrevo esse arquivo README verifiquei que existem até mesmo 6 jogos com estilo ímpar/par repetidos. Como estamos trabalhando com probabilidades extremamente pequenas, talvez seja o caso de reconsiderar essa regra para realizar uma análise mais profunda posteriormente, mas até o momento se houve um jogo anterior com estilo ímpar/par igual ao jogo atual, o jogo atual é descartado.
4. ** Coincidência de números**
   A probabilidade de um jogo se repetir é muito pequena, entretando pode ser que o jogo atual seja extremamente semelhante a algum jogo previamente sorteado. Esta parte das regras fixas descarta o jogo atual se ele tiver 13 bolas ou mais coincidentes com algum jogo previamente sorteado. Não houve nenhuma análise prévia para o estabelecimento deste número como sendo o número de corte. À época da criação do programa precisávamos gerar números com uma certa urgência e então coloquei este número fixo.

#### Regras pré-estabelecidas pelo usuário

O usuário pode estabelecer regras para validação de jogos antes de ordenar sua geração. As regras estabelecidas pelo usuário consistem, basicamente, de informar:

* Quantidade de números pares/ímpares
* Qual a maior sequência de números aceita por jogo
* Qual o maior intervalo de números aceito por jogo

O usuário pode informar quantas regras de validação ele quiser, permitindo que ele tenha várias regras de acordo com sua análise prévia dos resultados anteriores.

Ao clicar no botão de geração de jogos o programa salva um arquivo "regras.xml" no mesmo local onde o executável está. Esse arquivo contém as regras usadas para a criação dos jogos e será lido sempre que o sistema for iniciado, para evitar que o usuário tenha que informar as regras desejadas toda vez que quiser gerar novos números.
