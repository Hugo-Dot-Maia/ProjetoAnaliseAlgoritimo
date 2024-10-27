Projeto de Benchmark de Algoritmos de Ordenação
Este projeto realiza benchmarks de diferentes algoritmos de ordenação utilizando o BenchmarkDotNet para medir desempenho em termos de tempo médio de execução, erro, desvio padrão e memória alocada. Os algoritmos avaliados incluem:

QuickSort Padrão
QuickSort com Insertion Sort (para subarrays pequenos)
QuickSort com Pivô Mediana de Três
Conteúdo
Pré-requisitos
Como Executar
Algoritmos Avaliados
Resultados
Exportação de Resultados
Contribuição
Licença
Pré-requisitos
Antes de começar, você precisará dos seguintes recursos:

.NET 6.0 ou superior
BenchmarkDotNet (já configurado no projeto)
Visual Studio ou qualquer IDE compatível com .NET
Instale o pacote BenchmarkDotNet com o seguinte comando:

bash
Copiar código
dotnet add package BenchmarkDotNet
Como Executar
Clone o repositório:

bash
Copiar código
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
Compile e execute o projeto:

bash
Copiar código
dotnet run -c Release
Após a execução, os resultados dos benchmarks serão exibidos no console e salvos em um arquivo CSV e Excel para análise posterior.

Algoritmos Avaliados
QuickSort Padrão
Implementa o QuickSort clássico.

QuickSort com Insertion Sort
Utiliza o algoritmo Insertion Sort para subarrays pequenos, melhorando o desempenho para certos casos.

QuickSort com Mediana de Três
Utiliza a técnica de mediana de três como pivô, aumentando a eficiência em cenários adversos.

Resultados
Os resultados do benchmark são exportados para um arquivo CSV e Excel.
Exemplo de Estrutura do Resultado:

Método	M	Média (us)	Erro (us)	Desvio Padrão (us)	Alocado (B)
QuickSortBenchmark	5	1023.7	499.56	27.38	106
QuickSortWithInsertionBenchmark	5	1023.2	346.47	18.99	130
QuickSortMedianOfThreeBenchmark	5	106.8	26.13	1.43	128
Exportação de Resultados
Os resultados são salvos automaticamente em dois formatos:

CSV: benchmark_results.csv
Excel: benchmark_results.xlsx
O arquivo Excel pode ser aberto com qualquer software de planilhas, como Microsoft Excel ou Google Sheets.

Contribuição
Sinta-se à vontade para abrir issues e enviar pull requests com melhorias ou novos algoritmos de ordenação.

Fork este repositório
Crie uma branch para a sua feature (git checkout -b feature/algoritmo-novo)
Commit suas mudanças (git commit -am 'Adiciona algoritmo novo')
Push para a branch (git push origin feature/algoritmo-novo)
Abra um Pull Request
Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

Contato
Em caso de dúvidas ou sugestões, sinta-se à vontade para entrar em contato:

Email: seu-email@exemplo.com
GitHub: seu-usuario
