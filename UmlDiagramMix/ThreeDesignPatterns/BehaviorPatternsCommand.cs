using System;

namespace UmlDiagramMix.BehaviorPatterns
{
    // Command interfaces
    public interface ICommand
    {
        void Execute();
    }

    // Concrete Command classes
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

    // Receiver class (Object that performs the commands)
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

    // Client class (Object that uses the commands)
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

            saveButton.Shortcut(); // Çıktı: "Save command executed"
            printButton.Shortcut(); // Çıktı: "Print command executed"
            openButton.Shortcut(); // Çıktı: "Open command executed"
        }
    }
}
