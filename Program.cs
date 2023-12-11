using System;
namespace PedraPapelTesoura{
class Classe{
static void Main(String[] args){

//variáveis
Random random = new Random();
bool jogarDenovo = true;
String jogador;
String computador;
String resposta;

//loop
while(jogarDenovo){
    jogador = "";
	computador = "";
	resposta = "";
	
    while(jogador != "PEDRA" && jogador != "PAPEL" && jogador != "TESOURA"){
	
Console.Write("você vai jogar: PEDRA, PAPEL OU TESOURA? ");
jogador = Console.ReadLine();
jogador = jogador.ToUpper();
}

switch(random.Next(1,4)){
    case 1:
	 computador = "PEDRA";
	break;
	
	case 2:
	computador = "PAPEL";
	break;
	
	case 3:
	computador = "TESOURA";
	break;
	
	
	

}
Console.WriteLine("jogador: "+jogador);
Console.WriteLine("computador: "+computador);

switch(jogador){
case "PEDRA":

if(computador == "PEDRA"){
Console.WriteLine("ocorreu um empate!");
}
else if(computador == "PAPEL"){
Console.WriteLine("você perdeu!");
}
else{
Console.WriteLine("você venceu!");
}
break;

case "PAPEL":
if(computador == "PEDRA"){
Console.WriteLine("você venceu!");
}

else if(computador == "PAPEL"){
Console.WriteLine("ocorreu um empate!");
}

else{
Console.WriteLine("você perdeu!");
}
break;

case "TESOURA":
if(computador == "PEDRA"){
Console.WriteLine("você perdeu!");
}

else if(computador == "PAPEL"){
Console.WriteLine("você venceu!");
}

else{
Console.WriteLine("ocorreu um empate!");
}
break;
}

Console.WriteLine("gostaria de jogar novamente (S/N): ");
resposta = Console.ReadLine();
resposta = resposta.ToUpper();

if(resposta == "S"){
jogarDenovo = true;

}
else{
jogarDenovo = false;
}

Console.WriteLine("muito obrigado pôr jogar!");
}


}
}
}