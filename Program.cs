
//variáveis que receberão os valores; que no caso, pela proposta do desafio, já receberam dados previamente
double sp = 67.83643, rj = 36.67866, mg = 29.22988, es = 7.16548, outros = 19.84953, 
total = sp + rj + mg + es + outros;


/*código para recebimento de eventuais novos valores (não está sendo considerado armazenamento de dados antigos)
 
Console.Writeline("Insira o faturamento desse mês para o estado de São Paulo: ");
sp = double.Parse(Console.Readline());
Console.Writeline("Insira o faturamento desse mês para o estado do Rio de Janeiro: ");
rj = double.Parse(Console.Readline());
Console.Writeline("Insira o faturamento desse mês para o estado de Minas Gerais: ");
mg = double.Parse(Console.Readline());
Console.Writeline("Insira o faturamento desse mês para o estado do Espírito Santo: ");
es = double.Parse(Console.Readline());
Console.Writeline("Insira o faturamento desse mês para o restante dos locais operacionais: ");
outros = double.Parse(Console.Readline());
 
 */

//variáveis de cálculo percentual
double psp, prj, pmg, pes, pout;

//cálculo percentual
psp = (sp / total) * 100;
prj = (rj / total) * 100;
pmg = (mg / total) * 100;
pes = (es / total) * 100;
pout = (outros / total) * 100;

//transformação de percentual double para int
int pspint, prjint, pmgint, pesint, poutint;
pspint = (int)Math.Round(psp);
prjint = (int)Math.Round(prj);
pmgint = (int)Math.Round(pmg);
pesint = (int)Math.Round(pes);
poutint = (int)Math.Round(pout);

//saída de dados
Console.WriteLine("Faturamento Percentual em SP:{0}%" +
    "\nFaturamento Percentual no RJ:{1}%" +
    "\nFaturamento Percentual em MG:{2}%" +
    "\nFaturamento Percentual no ES:{3}%" +
    "\nFaturamento Percentual no restante das áreas atuantes (outros):{4}%",pspint, prjint, pmgint, pesint, poutint);

Console.ReadKey();
