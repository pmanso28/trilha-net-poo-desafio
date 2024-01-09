# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me <br>


**Languages** <br>
- [Português](#português)  <br>
- [English](#english)

### Português

## Aviso
O projeto original (que recebeu o fork) estava em .NET 6.0 e no momento não sei atualizá-lo para 8.0, mas assim que aprender assim o farei.

## Desafio de projeto
Atividade de projeto de programação orientada a objeto feita como parte do Decola Tech Avanade 2024 

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e Validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código que recebeu o fork quase não tinha lógica e, além fazer o que foi solicitado, também adicionei uma lista para armazenar os aplicativos instalados bem como um método de desinstalação. Também tive a ideia de limitar a quantidade de aplicativos que poderiam ser instalados com base no valor da memoria, mas não consegui descobrir como implementar minha ideia dentro de uma classe.

### English

## Notice
The original project (which received the fork) was in .NET 6.0 and at the moment I don't know how to update it to 8.0, but as soon as I learn so I will do so.

## Project challenge
This object oriented programming project was made as part of the Decola Tech Avanade 2024 course's set of projects.

## Context 
You are responsible for modeling a system that works with smartphones. To do this, you were asked to abstract a smartphone and provide ways for different brands and models to have their own behavior, enabling greater code reuse using object orientation.

## Proposal
You need to create a console application in .NET, mapping an abstract class and specific classes for two types of phones: Nokia and iPhone.
You must create your classes as informed below:

![Diagrama classes](Imagens/diagrama.png)

## Rules and Checks
1. The **Smartphone** class **must** be abstract, not allowing it to be instanced and serving only as model.
2. The **Nokia** and **Iphone** classes must inherit **Smartphone**.
3. The **InstalarAplicativo** method must be overwritten in the **Nokia** and **Iphone** classes, as the two of them have different ways of installing aplications.

## Solution
The code that received the fork had almost no logic and among doing what was requested I also added a list to store the installed apps as well as an uninstalling method. I also had the idea of limiting the amount of apps that could be installed based on the memoria value, but couldn't find how to implement my idea inside a class.
