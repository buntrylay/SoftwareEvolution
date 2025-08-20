namespace classFunction
{
    public class Calculator
    {
        public string CurrentInput { get; set; } = "";
        public double Result { get; set; } = 0;
        public string Operation { get; set; } = "";
        public bool OperationPending { get; set; } = false;

        public void AppendInput(string value)
        {
            CurrentInput += value;
        }

        public void Clear()
        {
            CurrentInput = "";
            Result = 0;
            Operation = "";
            OperationPending = false;
        }

        public string Evaluate()
        {
            if (OperationPending)
            {
                double secondNum = double.Parse(CurrentInput);
                switch (Operation)
                {
                    case "+": Result += secondNum; break;
                    case "-": Result -= secondNum; break;
                    case "*": Result *= secondNum; break;
                    case "/":
                        if (secondNum != 0)
                            Result /= secondNum;
                        else
                            return "Cannot divide by zero.";
                        break;
                }
                CurrentInput = "0";
                OperationPending = false;
                return Result.ToString();
            }
            return CurrentInput;
        }

        public void SetOperation(string op)
        {
            if (OperationPending)
            {
                Evaluate();
            }
            Operation = op;
            Result = double.Parse(CurrentInput);
            CurrentInput = "";
            OperationPending = true;
        }
    }
}