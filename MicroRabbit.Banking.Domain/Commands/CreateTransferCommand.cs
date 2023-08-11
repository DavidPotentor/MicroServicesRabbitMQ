namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand: TransferCommand
    {
        public CreateTransferCommand(int fromAccount, int toAccount, decimal transferAmount)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            TransferAmount = transferAmount;
        }



    }
}
