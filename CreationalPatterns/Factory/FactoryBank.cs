namespace bank;

public class FactoryBank : IFactoryBank
{
    public IBank GetBankObject(string CardCode)
    {
        switch (CardCode)
        {
            case "123456": return new BankA();
            case "000000": return new BankB();
        }
        return null;
    }
}