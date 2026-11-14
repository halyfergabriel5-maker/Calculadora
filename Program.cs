int op = 1;
double num1;
double num2;
double res;
double valor;

while(op != 0){
    //calculadora|sub-rotinas

    Console.WriteLine("_____CALCULADORA_____\n");



    Console.WriteLine("digite a operação que deseja realizar:\n1)adição\n2)subtração\n3)multiplicação\n4)divisão\n");
    //variavel op guarda o valor da operação escolhida.
    int valorD = int.Parse(Console.ReadLine()!);

    op = valorD;

    if(op < 1 || op > 4){
        Console.WriteLine("digite um valor valido");
        }
    else if(op == 0)
    {
        Console.WriteLine("obrigado por usar o programa");

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

      
    }

    
}

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
  if(num1 == 0 || num2 == 0)
    {
        Console.WriteLine("divisões por zero não são permitidas");
        return 0;
    }
    else{
  res = (num1 / num2);
  return res;
    }
  
}





