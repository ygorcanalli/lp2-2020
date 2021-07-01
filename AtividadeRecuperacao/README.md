# Atividade de Recuperação

A presente avitidade de recuperação consistem e utilizar os conceitos de orientação a objeto para desenvolver as classes ausentes no projeto. O contexto do projeto é uma pequena escola infantil, onde existem professores, alunos e turmas. 

O objetivo é fazer com que a classe Main disponibilizada seja executada produzindo como saída os relatórios apresentados ao final deste documento. A interface IImprimível e a classe Relatório também já estão prontas e disponíveis para uso.

## Classes a serem implementadas

Para desenvolvimento desta tarefa você deverá criar e codidificar as seguintes classes:

 - **Pessoa**
    - classe abstrata
    - assina **IImprimivel**
    - atributo **nome**
 - **Aluno**
    - herda de **Pessoa**
    - atributo **matrícula**
 - **Professor**
    - herda de **Pessoa**
    - atributo **email**
 - **Turma**
    - assina **IImprimivel**
    - atributo **nome**
    - atributo **serie**
    - atributo **alunos** (List)
    - método **AdicionarAluno**

Para o bom desenvolvimento desta tarefa você deverá fazer uso dos seguintes conceitos de orientação a objetos:

 - Classes
 - Objetos
 - Métodos
 - ConstrutoresWS
 - Sobrescrita
 - Herança
 - Interfaces
 - Polimorfismo
 - Encapsulamento

## Saída esperada:
```
======== RELATÓRIO ========
Alunos
===========================
Relatório de Alunos
========== ITENS ==========
Nome: Jo
Matricula: A78265139
---------------------------
Nome: Lala
Matricula: A27346133
---------------------------
Nome: Lis
Matricula: A21312312
---------------------------
Nome: Lô
Matricula: A457238423
---------------------------
Nome: Titi
Matricula: A382735922
---------------------------
Nome: Juca
Matricula: A018367541
---------------------------
===========================

======== RELATÓRIO ========
Professores
===========================
Relatório de Professores
========== ITENS ==========
Nome: Anaxarmandra
Email: anax@email.com
---------------------------
Nome: Hermenegildo
Email: herm@email.com
---------------------------
Nome: Benevides
Email: bene@email.com
---------------------------
===========================

======== RELATÓRIO ========
Turmas
===========================
Relatório de Turmas
========== ITENS ==========
Turma: 101
Serie: 1° série
Professores Anaxarmandra e Hermenegildo
Alunos: Jo Lala Lis
---------------------------
Turma: 201
Serie: 2° série
Professores Hermenegildo e Benevides
Alunos: Lô Titi Juca
---------------------------
===========================
```
