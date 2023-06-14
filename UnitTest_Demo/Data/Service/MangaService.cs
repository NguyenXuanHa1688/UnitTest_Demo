using UnitTest_Demo.Data.Interface;
using UnitTest_Demo.Model;

namespace UnitTest_Demo.Data.Service
{
    public class MangaService : IManga
    {
        private readonly DataContext _context;

        public MangaService(DataContext context)
        {
            _context = context;
        }

        public List<Manga> GetAll()
        {
            var list = _context.Mangas.ToList();
            return list;
        }

        public Manga Post(Manga m)
        {
            _context.Mangas.AddAsync(m);
            _context.SaveChangesAsync();
            return m;
        }

        public Manga Put(Manga m)
        {
            var MangaToEdit = _context.Mangas.Where(x => x.Id == m.Id).FirstOrDefault();
            MangaToEdit.Name = m.Name;
            MangaToEdit.Description = m.Description;
            MangaToEdit.price = m.price;
            _context.SaveChanges();
            return MangaToEdit;
        }

        public List<Manga> Delete(int mangaId)
        {
            var MangaToDelete = _context.Mangas.Where(x => x.Id == mangaId).FirstOrDefault();
            _context.Remove(MangaToDelete);
            _context.SaveChanges();
            return _context.Mangas.ToList();
        }
    } 
}
