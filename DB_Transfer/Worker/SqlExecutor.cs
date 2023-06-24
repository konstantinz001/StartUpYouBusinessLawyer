using DB_Transfer.Model;

namespace DB_Transfer.Worker
{
    public class SqlExecutor : ISqlExecutor
    {
        private readonly ISqlDataAccess _db;
        public SqlExecutor(ISqlDataAccess db)
        {
            _db = db;
        }


        public async Task<List<TransferModel>> getUmfragenStudent()
        {
            string sql = "Select * FROM Umfragen WHERE Zielgruppe = 'Student';";
            var umfragen = await _db.LoadDataAsync<TransferModel, dynamic>(sql, new { });

            return umfragen;
        }

        public async Task<List<TransferModel>> getUmfragenVortragende()
        {
            string sql = "Select * FROM Umfragen WHERE Zielgruppe = 'Vortragende';";
            var umfragen = await _db.LoadDataAsync<TransferModel, dynamic>(sql, new { });

            return umfragen;
        }

        public async Task<List<TransferModel>> getUmfragenByID(int id)
        {
            string sql = "Select * FROM Umfragen WHERE ID = @id;";
            var umfragen = await _db.LoadDataAsync<TransferModel, dynamic>(sql, new { id = id });

            return umfragen;
        }

        public async Task insertUmfrage(TransferModel umfrage)
        {
            string sql = "INSERT INTO Umfragen " +
                        "(ID, UmfragenID, Frage, Antwort, Typ, Datum, Zielgruppe) " +
                        "values(@id, @umfragenID, @frage, @antwort, @typ, GETDATE(), @zielgruppe)";
            await _db.SaveDataAsync<dynamic>(sql, new { id = umfrage.ID, umfragenID = umfrage.UmfragenID, frage = umfrage.Frage, antwort = umfrage.Antwort, typ = umfrage.Typ, zielgruppe = umfrage.Zielgruppe });
        }


        public async Task updateUmfrage(TransferModel umfrage)
        {
            string sql = "Update Umfragen " +
                        "SET UmfragenID = @umfragenID, Frage = @frage, Antwort =@antwort, Typ = @typ " +
                        "WHERE ID = @id";
            await _db.SaveDataAsync<dynamic>(sql, new { id = umfrage.ID, umfragenID = umfrage.UmfragenID, frage = umfrage.Frage, antwort = umfrage.Antwort, typ = umfrage.Typ });
        }


        public async Task deleteAllUmfrage()
        {
            string sql = "Delete From Umfragen";
            await _db.SaveDataAsync<dynamic>(sql, new { });
        }

        public async Task deleteUmfrageByID(string id)
        {
            string sql = "Delete From Umfragen WHERE ID = @id";
            await _db.SaveDataAsync<dynamic>(sql, new { id = id });
        }
    }
}
