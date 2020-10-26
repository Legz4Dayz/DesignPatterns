public interface ICommand{

    public void execute();
    public void unexecute();
    public void show(); // for testing purposes
}