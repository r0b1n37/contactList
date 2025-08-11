using Commands;

namespace Utils
{
    public class HistoryList
    {
        private List<Command> _commands = new();
        private int _cursor = -1;
        private const int MAX_SIZE = 50;

        public void Add(Command command)
        {
            if (_cursor < _commands.Count - 1)
            {
                _commands.RemoveRange(_cursor + 1, _commands.Count - _cursor - 1);
            }

            if (_commands.Count == MAX_SIZE)
            {
                _commands.RemoveAt(0);
                _cursor--;
            }

            _commands.Add(command);
            _cursor = _commands.Count - 1;
        }

        public void Undo()
        {
            if (!CanUndo) return;
            _commands[_cursor].Undo();
            _cursor--;
        }

        public void Redo()
        {
            if (!CanRedo) return;
            _cursor++;
            _commands[_cursor].Redo();
        }

        public bool CanUndo => _cursor >= 0;
        public bool CanRedo => _cursor < _commands.Count - 1;

        public IEnumerable<string> History => _commands.Select(c => c.Name);
    }

}
