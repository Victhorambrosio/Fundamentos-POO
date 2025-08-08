Console.WriteLine("********** Listas **********");
List<string> tarefas = new List<string>();
tarefas.Add("Lavar a louça");
tarefas.Add("Lavar o banheiro");
tarefas.Add("Tirar o lixo");
tarefas.Add("Fazer o almoço");
tarefas.Add("Dormir");

tarefas.Insert(2, "Passar pano na casa");

tarefas[4] = "Fazer a janta";

bool achou = tarefas.Contains("Lavar o banheiro");

if (achou)
{
    Console.WriteLine("\nTarefa existe");
}
else
    Console.WriteLine("\nTarefa não existe");

tarefas.Remove("Lavar o banheiro");

foreach (string item in tarefas)
{
    Console.WriteLine(item);
}

Console.WriteLine("************************* Atividade 02 ************************");

Dictionary<string, int> dicionario = new Dictionary<string, int>();

dicionario.Add("Robert", 991234567);
dicionario.Add("Filomena", 991234568);
dicionario.Add("Chaolin", 991234569);
dicionario.Add("Osvaldo", 991234570);

Console.WriteLine("\nDicionário de contatos");
foreach (KeyValuePair<string, int> item in dicionario)
{
    Console.WriteLine($"Nome: {item.Key}, Telefone: {item.Value}");
}

Console.WriteLine("\nAlterando o telefone de Chaolin");
dicionario["Chaolin"] = 991234580;
foreach (var item in dicionario)
{
    Console.WriteLine($"Nome: {item.Key}, Telefone: {item.Value}");
}

Console.WriteLine("\nPesquisando uma pessoa no dicionario");
int telefone;
if (dicionario.TryGetValue("Osvaldo", out telefone))
{
    Console.WriteLine($"Telefone de Osvaldo: {telefone}");
}
else
{
    Console.WriteLine("Pessoa não encontrada");
}

dicionario.Remove("Filomena");
foreach (var item in dicionario)
{
    Console.WriteLine($"Nome: {item.Key}, Telefone: {item.Value}");
}


Console.WriteLine("\n************************* Atividade 03 ************************\n");

Queue<string> fila = new Queue<string>();

fila.Enqueue("André");
fila.Enqueue("Romário");
fila.Enqueue("José");
fila.Enqueue("Yuri");
fila.Enqueue("Lucas");

foreach (var pessoa in fila)
{
    Console.WriteLine(pessoa);
}
string atendido = fila.Dequeue();
Console.WriteLine($"\n{atendido} foi atendido e saiu da fila\n");
