//calculadora|sub-rotinas



Console.WriteLine("_____CALCULADORA_____\n");
double num1;
double num2;
double res;
double valor;

Console.WriteLine("digite a operação que deseja realizar:\n1)adição\n2)subtração\n3)multiplicação\n4)divisão");
//variavel op guarda o valor da operação escolhida.
int op = int.Parse(Console.ReadLine()!);
do
{

    if(op < 1 || op > 4){
        Console.WriteLine("digite um valor valido");
        }
    else{
        switch(op){
            case 1:
                valor = adicao();
                Console.WriteLine($"seu resultado é: {valor}\n");
                break;

            case 2:
                valor = subtracao();
                Console.WriteLine($"seu resultado é: {valor}\n");
                break;
        
            case 3:
                valor = multiplicacao();
                Console.WriteLine($"seu resultado é: {valor}\n");
                break;

            case 4:
                valor = divisao();
                Console.WriteLine($"seu resultado é: {valor}\n");
                break;

        }
        
      Console.WriteLine("digite a operação que deseja realizar:\n1)adição\n2)subtração\n3)multiplicação\n4)divisão");
    
      op = int.Parse(Console.ReadLine()!);  
    }
}while(op != 0);

double adicao(){
  Console.WriteLine("digite os numeros que deseja realiazar a operação: ");
  num1 = Convert.ToDouble(Console.ReadLine());
  num2 = Convert.ToDouble(Console.ReadLine());
  res = (num1 + num2);
  return res;
  
}

double subtracao(){
  Console.WriteLine("digite os numeros que deseja realiazar a operação: ");
  num1 = Convert.ToDouble(Console.ReadLine());
  num2 = Convert.ToDouble(Console.ReadLine());
  res = (num1 - num2);
  return res;
  
}

double multiplicacao(){
  Console.WriteLine("digite os numeros que deseja realiazar a operação: ");
  num1 = Convert.ToDouble(Console.ReadLine());
  num2 = Convert.ToDouble(Console.ReadLine());
  res = (num1 * num2);
  return res;
  
}

double divisao(){
  Console.WriteLine("digite os numeros que deseja realiazar a operação: ");
  num1 = Convert.ToDouble(Console.ReadLine());
  num2 = Convert.ToDouble(Console.ReadLine());
  res = (num1 / num2);
  return res;
  
}





