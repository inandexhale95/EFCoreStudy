using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace MMO_EFCore
{
    internal class Program
    {
        static void InitializeDB(bool forceReset = false)
        {
            using AppDbContext db = new AppDbContext();

            if (!forceReset && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                return;

            db.Database.EnsureDeleted();
            // 클래스 모델링과 일치하게 테이블 생성
            db.Database.EnsureCreated();

            Console.WriteLine("DB initialized");
        }

        static void Main(string[] args)
        {
            InitializeDB(forceReset: true);
        }
    }
}
