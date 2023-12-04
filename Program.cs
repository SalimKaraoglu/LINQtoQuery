using LINQtoQuery.Infrastructure.Context;
using LINQtoQuery.Models.Abstract;

using (var db = new AppDbContext())
{
    #region Select
    //var genres = db.Genre.Select(x => new

    //{
    //	x.Id,
    //	x.Name,
    //	x.CreatedDate,
    //	x.Status
    //}).ToList();

    //foreach (var genre in genres)
    //{
    //       Console.WriteLine($"Id: {genre.Id}\nName: {genre.Name}\nCreated Date: {genre.CreatedDate}\nStatus: {genre.Status}\n====================");
    //   }
    #endregion

    #region Where - 1
    //// Fiyatı 7 ile 14 arasında olan kitapları listeleyelim

    //var books = db.Books.Where(x => x.Price >= 7 && x.Price <= 14)
    //                    .Select(x => new
    //                    {
    //                        x.Id,
    //                        x.Title,
    //                        x.Price,
    //                        x.Status
    //                    }).ToList();
    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n================");
    //}
    #endregion

    #region Where - 2 
    //// Id'si 1 ile 5 arasında olan yazarları sıralayalım

    //var authors = db.Authors.Where(x => x.Id >= 1 && x.Id <= 5)
    //                        .Select(x => new
    //                        {
    //                            x.Id,
    //                            x.FullName,
    //                            x.CreatedDate,
    //                            x.Status
    //                        }).ToList();
    //foreach (var author in authors)
    //{
    //    Console.WriteLine($"Id: {author.Id}\nFull Name: {author.FullName}\nCreateDate: {author.CreatedDate}\nStatus: {author.Status}\n=================");
    //}
    #endregion

    #region OrderBy - 1
    //// Id'si 1 ile 10 Arasıdaki yazarları isimlerine göre A'dan Z'ye sıralayalım
    //var authors = db.Authors.Where(x => x.Id >= 1 && x.Id <= 10)
    //                        .OrderBy(x => x.FirstName)
    //                        .Select(x => new
    //                        {
    //                            x.Id,
    //                            x.FullName,
    //                            x.CreatedDate,
    //                            x.Status
    //                        }).ToList();
    //foreach (var author in authors)
    //{
    //    Console.WriteLine($"Id: {author.Id}\nFull Name: {author.FullName}\nCreateDate: {author.CreatedDate}\nStatus: {author.Status}\n=================");
    //}
    #endregion

    #region OrderBy - 2
    //// Fiyatı 10'dan büyük olan kitapların fiyat bilgisine göre çoktan aza sıralanması
    //var books = db.Books.Where(x => x.Price >= 10)
    //                    .OrderByDescending(x => x.Price)
    //                    .Select(x => new
    //                    {
    //                        x.Id,
    //                        x.Price,
    //                        x.Title,
    //                        x.Status,
    //                    }).ToList();
    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nPrice: {book.Price}\nTitle: {book.Title}\nStatus: {book.Status}\n=================");
    //}
    #endregion

    #region First - 1
    // Kitap tablosundaki birinci kaydı getirelim
    //var book = db.Books.First();
    //Console.WriteLine($"Id: {book.Id}\nPrice: {book.Price}\nTitle: {book.Title}\nStatus: {book.Status}\n=================");
    #endregion

    #region First - 2
    //// Kitap tablosundaki 51. kaydı getirelim
    //// Veri tabanında verilen şartı sağlayan bir kayıt bulamazsa hata fırlatır
    //try
    //{
    //    var book = db.Books.First(x => x.Id == 51);
    //    Console.WriteLine($"Id: {book.Id}\nPrice: {book.Price}\nTitle: {book.Title}\nStatus: {book.Status}\n=================");
    //}
    //catch (Exception)
    //{

    //    Console.WriteLine("Böyle Bir Kitap Bulunamadi");
    //}
    #endregion

    #region FirstOrDefault - 1
    // Kitap tablosundaki 51.kaydı getirelim
    // FirstOrDefualt methodu sorgu sonucu dönen veri kümesi boş ise First() methodu gibi  hata fırlatmaz , null döner.
    //var book = db.Books.FirstOrDefault(x => x.Id == 51);
    //if (book != null)
    //    Console.WriteLine($"Id: {book.Id}\nPrice: {book.Price}\nTitle: {book.Title}\nStatus: {book.Status}\n=================");
    //else
    //    Console.WriteLine("Böyle Bir Kitap Bulunamadı!");
    #endregion

    #region FirstOrDefault - 2
    //// Tür Adı history olan kayıtları getirelim
    //var genre = db.Genre.FirstOrDefault(x => x.Name == "History");
    //if (genre != null)
    //    Console.WriteLine($"Id: {genre.Id}\nName: {genre.Name}\nStatus: {genre.Status}\n==============");
    //else
    //    Console.WriteLine("Böyle Bir Tür Bulunamadı!");
    #endregion

    #region Find
    //// Sadece Id ler üzerinde arama yapar ve bulduğu ilk sonucu size döndürür

    //var genre = db.Genre.Find("History");
    //if (genre != null)
    //    Console.WriteLine($"Id: {genre.Id}\nName: {genre.Name}\nStatus: {genre.Status}");
    //else
    //    Console.WriteLine("Böyle Nir Tür Bulunamadı!");
    #endregion

    #region Take
    ////Fiyatı en yüksek beş kitabı listeleyelim
    //var books = db.Books.OrderByDescending(x => x.Price)
    //                    .Take(5)
    //                    .Select(x => new
    //                    {
    //                        x.Id,
    //                        x.Title,
    //                        x.Price,
    //                        x.Status
    //                    }).ToList();
    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===========");
    //}
    #endregion

    #region TakeandSkip
    //// Türü history olan ve fiyatı en yüksek dördüncü kitabı getirin.
    //var books = db.Books.Where(x => x.GenreId == "history")
    //                    .OrderByDescending(x => x.Price)
    //                    .Skip(3) //Dördüncü kaydı dediği için ilk üçünü geçmek için 3 diyoruz
    //                    .Take(1) //Bir tane kitap getir dediği için bir diyoruz.
    //                    .Select(x => new
    //                    {
    //                        x.Id,  
    //                        x.Title,
    //                        x.Price,
    //                        x.Status
    //                    }).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}");
    //}
    #endregion

    #region Contains
    //// İçerisinde A harfi geçen kitapları getirin
    //var books = db.Books.Where(x => x.Title.Contains("A")).ToList();
    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}");
    //}
    #endregion

    #region StartsWith
    //// D harfi ile başlayan kitapları getirin
    //var books = db.Books.Where(x => x.Title.StartsWith("D")).ToList();
    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n================");
    //}
    #endregion

    #region EndsWith
    //// E Harfi ile bitenler
    //var books = db.Books.Where(x => x.Title.EndsWith("E")).ToList();
    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n================");
    //}
    #endregion

    #region Any
    //// Veri tablosunda türü 'history' olan kitap varmı (true  *  false döner)
    //var result = db.Books.Any(x => x.GenreId == "History");
    //if (result)
    //    Console.WriteLine("Türü History Olan Kitap Vardır.");
    //else
    //    Console.WriteLine("Türü History Olan Kitap Bulunamadı!");
    #endregion

    // AGRAGATE FUNCTİONS

    #region Count
    //var result = db.Books.Count();
    //Console.WriteLine($"Veri Tabanındaki Kitap Sayısı: {result}");
    #endregion

    #region Sum
    //// Veri tabanındaki kitaplarının fiyatlarının toplamını getirelim
    //var result = db.Books.Sum( x => x.Price );
    //Console.WriteLine($"Veri Tabanıdaki Kitapların Fiyatları Toplamı: {result}TL");
    #endregion

    #region MinMax
    //// Fiyatı en ucuz ve en pahalı kitapların fiyatlarını gösterelim
    //var mostExpensive = db.Books.Max(x => x.Price);
    //var cheapest = db.Books.Min(x => x.Price);
    //Console.WriteLine($"Veri Tabanındaki En Pahalı Kitap: {mostExpensive}\nVeri Tabanındaki En Ucuz Kitap: {cheapest}");
    #endregion

    #region GrupBy With Count - 1
    ////Kitapları türlerine göre gruplayalım.
    //var result = db.Books.GroupBy(x => x.Genre.Name)  //Neye Göre gurplancaksa onu yazıyoruz.
    //                     .Select(x => new
    //                     {
    //                         GenreName = x.Key,       // Gruplamak İstediğimiz Sütun.
    //                         Count = x.Count()
    //                     }).ToList();
    //foreach (var item in result)
    //{
    //    Console.WriteLine($"Genre Name: {item.GenreName}\nBook Count: {item.Count}\n===========================");
    //}

    #endregion
}