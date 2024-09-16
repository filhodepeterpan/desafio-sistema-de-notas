using System;

class Program{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        int tarefas = 5;

        int[] notasSophia = {90, 86, 87, 98, 100, 94, 90};
        int[] notasAndre = {92, 89, 81, 96, 90, 89};
        int[] notasKarla = {90, 85, 87, 98, 68, 89, 89, 89};
        int[] notasIgor = {90, 95, 87, 88, 96, 96};
        int[] notasJulia = {29, 58, 61, 78, 55};
        int[] notasRonaldo = {82, 72, 81, 65, 90, 87};
        int[] notasMaria = {83, 77, 82, 86, 90, 89};

        string[] nomesDosEstudantes = {"Sophia", "André", "Karla", "Igor", "Júlia", "Ronaldo", "Maria"};

        int[] notasDosEstudantes = new int [0];

        string avaliacaoPorLetra = "";

        Console.Write("\n");
        Console.WriteLine("Estudante\t\tAvaliacao\n");

        foreach (string nome in nomesDosEstudantes)
        {
            string estudanteAtual = nome;

            if (estudanteAtual == "Sophia"){
            notasDosEstudantes = notasSophia;
            }
            else if (estudanteAtual == "André"){
                notasDosEstudantes = notasAndre;
            }
            else if (estudanteAtual == "Karla"){
                notasDosEstudantes = notasKarla;
            }
            else if (estudanteAtual == "Igor"){
                notasDosEstudantes = notasIgor;
            }
            else if (estudanteAtual == "Júlia"){
                notasDosEstudantes = notasJulia;
            }
            else if (estudanteAtual == "Ronaldo"){
                notasDosEstudantes = notasRonaldo;
            }
            else if (estudanteAtual == "Maria"){
                notasDosEstudantes = notasMaria;
            }

            int somaDasNotas = 0;

            decimal avaliacaoDoEstudanteAtual = 0;
            int tarefasAvaliadas = 0;

            foreach (int nota in notasDosEstudantes)
            {
                tarefasAvaliadas++;

                if (tarefasAvaliadas <= tarefas){
                    somaDasNotas += nota;
                }
                else{
                    somaDasNotas += nota / 10;
                }
            }

            avaliacaoDoEstudanteAtual = (decimal)(somaDasNotas) / tarefas;

            if (avaliacaoDoEstudanteAtual >= 97){
                avaliacaoPorLetra = "A+";
            }
            else if (avaliacaoDoEstudanteAtual >= 93){
                avaliacaoPorLetra = "A";
            }
            else if (avaliacaoDoEstudanteAtual >= 90){
                avaliacaoPorLetra = "A-";
            }
            else if (avaliacaoDoEstudanteAtual >= 87){
                avaliacaoPorLetra = "B+";
            }
            else if (avaliacaoDoEstudanteAtual >= 83){
                avaliacaoPorLetra = "B";
            }
            else if (avaliacaoDoEstudanteAtual >= 80){
                avaliacaoPorLetra = "B-";
            }
            else if (avaliacaoDoEstudanteAtual >= 77){
                avaliacaoPorLetra = "C+";
            }
            else if (avaliacaoDoEstudanteAtual >= 73){
                avaliacaoPorLetra = "C";
            }
            else if (avaliacaoDoEstudanteAtual >= 70){
                avaliacaoPorLetra = "C-";
            }
            else if (avaliacaoDoEstudanteAtual >= 67){
                avaliacaoPorLetra = "D+";
            }
            else if (avaliacaoDoEstudanteAtual >= 63){
                avaliacaoPorLetra = "D";
            }
            else if (avaliacaoDoEstudanteAtual >= 60){
                avaliacaoPorLetra = "D-";
            }
            else{
                avaliacaoPorLetra = "F";
            }
            Console.WriteLine($"{estudanteAtual}\t\t{avaliacaoDoEstudanteAtual}\t{avaliacaoPorLetra}");
        }

        Console.WriteLine("\nDigite Enter para continuar...");
        Console.ReadLine();
    }
}