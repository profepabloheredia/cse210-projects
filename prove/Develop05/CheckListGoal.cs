class CheckListGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, string points, int target, int bonus):base(name, description, points)
    {
        _target=target;
        _bonus= bonus;
        _amountCompleted=0;
    }

    public void SetAmount(int ammount)
    {
        _amountCompleted= ammount;
    }
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string text = $"CheckListGoal:{base.GetName()}~{base.GetDescription()}~{base.GetPoints()}~{_bonus}~{_target}~{_amountCompleted}";
        return text;
    }
    public override string GetDetailsString()
    {
        string complete =" ";
        bool isComplete = IsComplete();
        if (isComplete==true){complete="x";} 
        string text = $"[{complete}] {base.GetName()} ({base.GetDescription()}) -- Curretly completed {_amountCompleted}/{_target}."; 
        return text;
    }
    
}