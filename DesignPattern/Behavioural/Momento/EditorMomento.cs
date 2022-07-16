namespace DesignPattern.Behavioural.Momento;

public class EditorMomento
{
    public readonly int cursorRow;
    public readonly int cursorColumn;
    public readonly string editorContent;

    public EditorMomento(int x, int y, string content)
    {
        cursorRow = x;
        cursorColumn = y;
        editorContent = content;
    }
}
