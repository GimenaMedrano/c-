//ejercicio 1
byte edad;
try
{
    Console.WriteLine("ingrese su edad");
    edad= Convert.ToByte(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero de dos cifras");
    Console.WriteLine( $"no aparentas {edad} anios");
}
catch (Exception op)
{
    Console.WriteLine("Erros.Por favor revise el dato ingresado.");
    Console.WriteLine("La exepcion es: " + op.Message);
}
//ejercio 2
long var1, var2, op1, op2, op3; //long es un entero largo

Console.WriteLine("ingrese el primer numero, entero largo");
var1 = Convert.ToInt64(Console.ReadLine());//console.ReadLine() lee los datos ingresados por el ususario

Console.WriteLine("ingrese el segundo numero, entero largo");
var2 = Convert.ToInt64(Console.ReadLine());//Convert.ToInt64 convierte un valor a un entero de 64 bits

op1 = var1 + var2;
op2 = var1 - var2;
op3 = var1 * var2;

Console.WriteLine($"la suma de {var1} y {var2} es {op1}"); //Console.WriteLine imprime texto en pantalla
Console.WriteLine($"la resta de {var1} y {var2} es {op2}");
Console.WriteLine($"la multiplicacion de {var1} y {var2} es {op3}");

//ejercicio 3
byte uno, dos;
ushort mult;
try
{
    Console.WriteLine("ingrese el primer numero de dos cifras");
    uno = Convert.ToByte(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero de dos cifras");
    dos = Convert.ToByte(Console.ReadLine());
    mult = (ushort)(uno * dos);
    Console.WriteLine(value: $"el resultado de la multiplicacion es {mult}");
}
catch (Exception op)
{
    Console.WriteLine("Erros.Ingrese enteros de dos cifras.");
    Console.WriteLine("La exepcion es: " + op.Message);
}