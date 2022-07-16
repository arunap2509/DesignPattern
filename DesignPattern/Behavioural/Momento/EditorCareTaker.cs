namespace DesignPattern.Behavioural.Momento;

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