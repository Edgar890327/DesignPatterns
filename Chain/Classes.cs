using System;

namespace Chain
{
    public class AbstractStep
    {
        protected static string MessageToPrint;
        protected int Number { get; init; }
        protected string Message { get; init; }
        public readonly AbstractStep _nextStep;
        public AbstractStep(int number, string message, AbstractStep nextStep)
        {
            _nextStep = nextStep;
            Number = number;
            Message = message;
        }

        public AbstractStep()
        {

        }

        public virtual void Handle(int toVerify)
        {
            if(toVerify % Number==0)
            {
                MessageToPrint += Message;
            }
            _nextStep?.Handle(toVerify);
        }
    }

    public class NumberStep : AbstractStep
    {
        public NumberStep(int number, string message, AbstractStep nextStep):base(number, message, nextStep)
        {

        }
    }

    public class PrintStep : AbstractStep
    {
        public override void Handle(int toVerify)
        {
            MessageToPrint ??= toVerify.ToString();
            Console.WriteLine(MessageToPrint);
            MessageToPrint = null;
        }
    }
}
