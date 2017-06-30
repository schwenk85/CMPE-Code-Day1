namespace Isp
{
    public interface ITranslator
    {
        string Translate(string text);
    }

    public interface IFileLoader
    {
        string LoadFile(string filename);
    }
}