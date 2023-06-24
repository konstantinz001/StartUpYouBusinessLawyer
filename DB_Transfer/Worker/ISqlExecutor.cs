using DB_Transfer.Model;

namespace DB_Transfer.Worker
{
    public interface ISqlExecutor
    {
        Task deleteAllUmfrage();
        Task deleteUmfrageByID(string id);
        Task<List<TransferModel>> getUmfragenStudent();
        Task<List<TransferModel>> getUmfragenVortragende();
        Task<List<TransferModel>> getUmfragenByID(int id);
        Task insertUmfrage(TransferModel umfrage);
        Task updateUmfrage(TransferModel umfrage);
    }
}