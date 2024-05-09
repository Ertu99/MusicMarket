namespace MusicMarket.Core.Repositories;

public interface IUnitOfWork : IDisposable
{
    IMusicRepository Musics { get; }
    IArtistRepository Artists { get; }
    Task<int> CommitAsync(); //Bu metot, birim of work deseninin temel işlevlerinden biri olan değişiklikleri veritabanına kaydetmek için kullanılır. Task<int> türünde bir değer döndürür, bu da işlem sırasında etkilenen satır sayısını temsil edebilir.
}