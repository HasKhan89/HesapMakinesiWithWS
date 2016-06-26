using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TodoListWebApp
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class TodoListService : System.Web.Services.WebService
    {
        TodoListContext db = new TodoListContext();

        [WebMethod]
        public List<Gorev> List()
        {
            return db.Gorevler.ToList();
        }

        [WebMethod]
        public IslemSonuc Add(string gorevMetni, bool tamamlandiMi = false)
        {
            IslemSonuc result = new IslemSonuc();
            Gorev gorev = new Gorev();

            gorev.CreatedDate = DateTime.Now;
            gorev.UpdatedDate = null;
            gorev.IsCompleted = tamamlandiMi;
            gorev.Task = gorevMetni;

            db.Gorevler.Add(gorev);

            int etkilenenKayitSayisi = 0;

            try
            {
                etkilenenKayitSayisi = db.SaveChanges();
            }
            catch (Exception ex)
            {
                result.Sonuc = false;
                result.Mesaj = ex.Message;

                return result;
            }

            if (etkilenenKayitSayisi > 0)
            {
                result.Sonuc = true;
                result.Mesaj = "Ekleme işlemi gerçekleşti.";

                return result;
            }

            result.Sonuc = false;
            result.Mesaj = "Görev eklenemedi.";

            return result;

        }

        [WebMethod]
        public IslemSonuc Update(Gorev gorev)
        {
            IslemSonuc result = new IslemSonuc();

            Gorev guncellenecek = (from g in db.Gorevler
                                   where g.Id == gorev.Id
                                   select g).FirstOrDefault();

            if (guncellenecek != null)
            {
                guncellenecek.IsCompleted = gorev.IsCompleted;
                guncellenecek.Task = gorev.Task;
                guncellenecek.UpdatedDate = DateTime.Now;

                if (db.SaveChanges() > 0)
                {
                    result.Sonuc = true;
                    result.Mesaj = "Güncelleme işlemi gerçekleşti.";

                    return result;
                }
                else
                {
                    result.Sonuc = false;
                    result.Mesaj = "Görev güncellenemedi.";

                    return result;
                }
            }

            result.Sonuc = false;
            result.Mesaj = "Güncellenecek görev bulunamadı.";

            return result;
        }

        [WebMethod]
        public IslemSonuc Delete(int gorevId)
        {
            IslemSonuc result = new IslemSonuc();

            Gorev silinecek = db.Gorevler.Where(g => g.Id == gorevId).FirstOrDefault();

            if (silinecek != null)
            {
                db.Gorevler.Remove(silinecek);

                if (db.SaveChanges() > 0)
                {
                    result.Sonuc = true;
                    result.Mesaj = "Silme işlemi gerçekleşti.";

                    return result;
                }
                else
                {
                    result.Sonuc = false;
                    result.Mesaj = "Görev silinemedi.";

                    return result;
                }
            }

            result.Sonuc = false;
            result.Mesaj = "Silinecek görev bulunamadı.";

            return result;
        }

    }
}
