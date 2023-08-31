using ChainOfResponsability;

var vacation = new Vacation
{
    From = DateOnly.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
    To = DateOnly.Parse(DateTime.Now.AddDays(4).ToString("yyyy-MM-dd")),
    staffId = 1,
    staffName = "Mohamed Ali"
};
TeamLeaderHandler approvalHandler = new ();

approvalHandler.initialize(vacation);