using System;

class MainClass {
  public static void Main (string[] args) {
  
    Aluno a1 = new Aluno("Jo",   "A78265139");
    Aluno a2 = new Aluno("Lala", "A27346133");
    Aluno a3 = new Aluno("Lis",  "A21312312");
    Aluno a4 = new Aluno("Lô",   "A457238423");
    Aluno a5 = new Aluno("Titi", "A382735922");
    Aluno a6 = new Aluno("Juca", "A018367541");

    Professor p1 = new Professor("Anaxarmandra", "anax@email.com");
    Professor p2 = new Professor("Hermenegildo", "herm@email.com");
    Professor p3 = new Professor("Benevides", "bene@email.com");

    Turma t1 = new Turma("101", "1° série", p1, p2);
    t1.AdicionarAluno(a1);
    t1.AdicionarAluno(a2);
    t1.AdicionarAluno(a3);

    Turma t2 = new Turma("201", "2° série", p2, p3);
    t2.AdicionarAluno(a4);
    t2.AdicionarAluno(a5);
    t2.AdicionarAluno(a6);

    Relatorio rAlunos = new Relatorio("Alunos", "Relatório de Alunos");
    rAlunos.AdicionarItem(a1);
    rAlunos.AdicionarItem(a2);
    rAlunos.AdicionarItem(a3);
    rAlunos.AdicionarItem(a4);
    rAlunos.AdicionarItem(a5);
    rAlunos.AdicionarItem(a6);

    Relatorio rProfessores = new Relatorio("Professores", "Relatório de Professores");
    rProfessores.AdicionarItem(p1);
    rProfessores.AdicionarItem(p2);
    rProfessores.AdicionarItem(p3);

    Relatorio rTurmas = new Relatorio("Turmas", "Relatório de Turmas");
    rTurmas.AdicionarItem(t1);
    rTurmas.AdicionarItem(t2);

    rAlunos.ImprimirRelatorio();
    rProfessores.ImprimirRelatorio();
    rTurmas.ImprimirRelatorio();


  }
}