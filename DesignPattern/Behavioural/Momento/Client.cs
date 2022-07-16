namespace DesignPattern.Behavioural.Momento;

public class MomentoClient
{
    public static void Invoke()
    {
        var editor = new Editor("", 0, 0);

        editor.ChangeContent("hey there how are you \n this is all going fine!.");
        editor.SetCursorPosition(2, 0);

        var caretaker = new EditorCareTaker(editor);
        caretaker.Backup();

        editor.ChangeContent("hey i just wanted to change to this flaky text \n \n \n boom!!");
        editor.SetCursorPosition(4, 6);

        caretaker.Undo();

        Console.WriteLine($"the editor content now is {editor.GetContent()} " +
            $"and cursor is in {editor.GetCursorPosition()}");

        editor.ChangeContent("hey i just wanted to change to this flaky text \n \n \n boom!!");
        editor.SetCursorPosition(4, 6);

        caretaker.Backup();

        editor.ChangeContent("no...... not again come on man \n \n \n blah blah blah!!");
        editor.SetCursorPosition(7, 2);

        caretaker.Backup();

        caretaker.ListBackup();
    }
}

