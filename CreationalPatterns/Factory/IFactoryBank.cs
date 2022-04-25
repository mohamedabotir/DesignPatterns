namespace bank;

public interface IFactoryBank
{
    IBank GetBankObject(string CardCode);
}