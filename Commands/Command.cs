namespace Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute();
        public abstract void Undo();
        public virtual void Redo() => Execute();
    }
}
