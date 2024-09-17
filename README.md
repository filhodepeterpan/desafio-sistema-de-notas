# Desafio Sistema de Notas
## Desafio C# do Microsoft Learn

 &nbsp;

 O programa utiliza arrays para receber notas (de 0 a 100) de alunos e calcular suas médias. O número padrão de tarefas é 5, mas o programa suporta que notas extras sejam adicionadas com um peso menor (10% do valor da nota). Para tornar o processamento de dados mais eficaz, é usado foreach para processar aluno por aluno e nota por nota, resultando num foreach dentro de outro foreach (o foreach pai processa os nomes dos estudantes, enquanto o foreach filho soma as notas das tarefas, incluindo as extras.) Ainda dentro do foreach pai, é atribuída uma letra (baseada no sistema americano de avaliação) de acordo com a média do aluno. 
