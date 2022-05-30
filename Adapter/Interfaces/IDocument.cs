namespace Adapter.Models;

internal interface IDocument
{
    string Content { set; }
    void Draw();
    void Print();
}
