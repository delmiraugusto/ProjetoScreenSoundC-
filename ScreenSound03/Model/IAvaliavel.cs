namespace ScreenSound03.Model;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    
    double Media { get; }
}