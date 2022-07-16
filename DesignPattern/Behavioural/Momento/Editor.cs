namespace DesignPattern.Behavioural.Momento;

public class Editor
{
    private string _content;
    private int _cursorOnRow;
    private int _cursorOnColumn;

    public Editor(string content, int cursorOnRow, int cursorOnColumn)
    {
        _content = content;
        _cursorOnRow = cursorOnRow;
        _cursorOnColumn = cursorOnColumn;
    }

    public void SetCursorPosition(int cursorRow, int cursorColumn)
    {
        _cursorOnRow = cursorRow;
        _cursorOnColumn = cursorColumn;
    }

    public void ChangeContent(string content)
    {
        _content = content;
    }

    public (int x, int y) GetCursorPosition()
    {
        return (_cursorOnRow, _cursorOnColumn);
    }

    public string GetContent()
    {
        return _content;
    }

    public EditorMomento SaveMomento()
    {
        return new EditorMomento(_cursorOnRow, _cursorOnColumn, _content);
    }

    public void Restore(EditorMomento momento)
    {
        _content = momento.editorContent;
        _cursorOnColumn = momento.cursorColumn;
        _cursorOnRow = momento.cursorRow;
    }
}

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

public class EditorCareTaker
{
    private readonly Stack<EditorMomento> _editorMomentos;
    private readonly Editor _editor;

    public EditorCareTaker(Editor editor)
    {
        _editorMomentos = new();
        _editor = editor;
    }

    public void Backup()
    {
        _editorMomentos.Push(_editor.SaveMomento());
    }

    public void Undo()
    {
        var momento = _editorMomentos.Pop();

        _editor.Restore(momento);
    }

    public void ListBackup()
    {
        foreach (var momento in _editorMomentos)
        {
            Console.WriteLine($"backup with content as {momento.editorContent} " +
                $"and (x,y) in ({momento.cursorRow}, {momento.cursorColumn})");
        }
    }
}