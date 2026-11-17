namespace Modul7_GudangOOP.Exceptions;

// Langkah 2 Modul: Membuat Custom Exception turunan dari System.Exception
public class StokNegatifException : Exception
{
    public StokNegatifException(string message) : base(message)
    {
    }
}