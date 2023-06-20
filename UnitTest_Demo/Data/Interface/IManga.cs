using UnitTest_Demo.Model;

namespace UnitTest_Demo.Data.Interface
{
    public interface IManga
    {
        List<Manga> GetAll();
        List<Manga> Search(string key);
        Manga Post(Manga manga);
        Manga Put(Manga manga);
        List<Manga> Delete(int mangaId);

    }
}
