using System;

namespace UmlDiagramMix.BehaviorPatterns
{
    public interface ICommand
    {
        void Execute();
    }

    public class SaveCommand : ICommand
    {
        private readonly Receiver _receiver;

        public SaveCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Save();
        }
    }

    public class PrintCommand : ICommand
    {
        private readonly Receiver _receiver;

        public PrintCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Print();
        }
    }

    public class OpenCommand : ICommand
    {
        private readonly Receiver _receiver;

        public OpenCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Open();
        }
    }

    public class Receiver
    {
        public void Save()
        {
            Console.WriteLine("Save command executed");
        }

        public void Print()
        {
            Console.WriteLine("Print command executed");
        }

        public void Open()
        {
            Console.WriteLine("Open command executed");
        }
    }

    public class Button
    {
        private ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Shortcut()
        {
            _command.Execute();
        }
    }

    public class cOMMANDbEHavior
    {

        public void RunBehavior()
        {
            Receiver receiver = new Receiver();

            ICommand saveCommand = new SaveCommand(receiver);
            ICommand printCommand = new PrintCommand(receiver);
         
            ICommand openCommand = new OpenCommand(receiver);

            Button saveButton = new Button(saveCommand);
            Button printButton = new Button(printCommand);
            Button openButton = new Button(openCommand);

            saveButton.Shortcut(); 
            printButton.Shortcut(); 
            openButton.Shortcut(); 
        }
    }
}
