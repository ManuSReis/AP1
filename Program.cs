// Inicia a estrutura de repetição condicionada, enquanto a resposta for "S" o loop é reiniciado
        do
        {
            Console.Clear(); // Limpa a tela para uma nova consulta

            // Solicitação de informações do usuário
            Console.WriteLine("Calculadora de IMC e Idade\n");

            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine(); // Converte o dado informado para dentro da variável

            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe sua altura (em metros): ");
            double altura = double.Parse(Console.ReadLine()); 

            Console.Write("Informe seu peso (em quilogramas): ");
            double peso = double.Parse(Console.ReadLine());

            // Calcula o IMC
            double imc = CalcularIMC(peso, altura);

            // Determina a classificação do IMC
            string statusIMC = ClassificarIMC(imc);

            // Determina a faixa etária
            string faixaEtaria = ClassificarIdade(idade);

            // Exibe o relatório
            Console.Clear(); // Limpa a tela para mostrar o relatório
            Console.WriteLine("Relatório de Avaliação\n");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Altura: {altura} metros");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"IMC: {imc:F2}");
            Console.WriteLine($"Classificação IMC: {statusIMC}");
            Console.WriteLine($"Faixa Etária: {faixaEtaria}\n");

            // Pergunta se deseja realizar outra consulta
            Console.Write("Deseja realizar outra consulta? (S/N): ");
        } while (Console.ReadLine().Trim().ToUpper() == "S");

    // Realiza o calculo de IMC com base nos dados do usuário
    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    // Realiza a classificação de IMC baseado no calculo feito com os dados inseridos pelo usuário
    static string ClassificarIMC(double imc)
    {
        if (imc < 17)
            return "Muito abaixo do peso";
        else if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 25)
            return "Peso normal";
        else if (imc < 30)
            return "Acima do peso";
        else if (imc < 35)
            return "Obesidade Grau I";
        else if (imc < 40)
            return "Obesidade Grau II";
        else
            return "Obesidade Grau III";
    }

    // Realiza a classificação etária do usuário com base nos dados inseridos pelo usuário
    static string ClassificarIdade(int idade)
    {
        if (idade < 14)
            return "Criança";
        else if (idade < 20)
            return "Adolescente";
        else if (idade < 60)
            return "Adulto";
        else
            return "Idoso";
    }
