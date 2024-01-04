// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe a Versão 1");
string version1 = Console.ReadLine();

Console.WriteLine("Informe a Versão 2");
string version2 = Console.ReadLine();

var v1Array = version1.Split(".");
var v2Array = version2.Split(".");

Console.WriteLine("\n\nPossíveis resultados:");
Console.WriteLine("0 = Versões iguais \n1 = Versão 1 maior \n2 = Versão 2 maior\n");
Console.WriteLine("O resultado é: " + CompareVersions(v1Array, v2Array));


static int CompareVersions(string[] version1, string[] version2)
{
    int length = Math.Max(version1.Length, version2.Length);

    if (length == 0) length = version1.Length;

    for (int i = 0; i < length; i++)
    {
        int v1Part = (i < version1.Length) ? int.Parse(version1[i]) : 0;
        int v2Part = (i < version2.Length) ? int.Parse(version2[i]) : 0;

        if (v1Part < v2Part)
        {
            return 2;
        }
        else if (v1Part > v2Part)
        {
            return 1;
        }
    }

    return 0;
}
