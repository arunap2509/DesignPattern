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