using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Sistemi.Properties
{
    class ConnectionClass
    {

        public string Address = System.IO.File.ReadAllText(@"C:\SqlAddress.txt");

        public string BookJoin = 
            "SELECT " +
            "b.id AS [ID]," +
            "b.isbn_no AS [ISBN No]," +
            "b.book_name AS [Kitap Adı]," +
            "t.type_name AS [Tür Adı]," +
            "w.writer_name AS [Yazar Adı]," +
            "w.writer_surname AS [Yazar Soyadı]," +
            "s.id AS [Kitap alınmışsa öğrencinin IDsi]," +
            "s.st_name AS [Kitap alınmışsa öğrencinin adı]," +
            "s.st_surname AS [Kitap alınmışsa öğrencinin soyadı], " +
            "s.st_tr_id AS [Kitap alınmışsa öğrencinin TC kimlik numarası]," +
            "b.taken_date AS [Kitabın alındığı tarih]," +
            "b.delivery_date AS [Teslim edileceği tarih]," +
            "b.is_delivered AS [Kitap teslim edildi mi ?] " +
            "FROM book b " +
            "INNER JOIN writer w ON w.id = b.writer_no " +
            "INNER JOIN type t ON t.id = b.type_no " +
            "LEFT JOIN student s ON s.id = b.st_id where";

        public string StudentJoin = "";

        public string OrderQuery = "UPDATE book SET " +
            "st_id=@st_id , " +
            "is_delivered = @is_delivered , " +
            "taken_date=@taken_date , " +
            "delivery_date=@delivery_date " +
            "where";

        public string DeleteOrderQuery = "UPDATE book SET " +
            "st_id=@st_id , " +
            "taken_date=@taken_date, " +
            "book_name=@book_name , " +
            "is_delivered=@is_delivered, " +
            "delivery_date=@delivery_date " +
            "where";

        public string WriterQuery = "SELECT " +
            "id AS [ID]," +
            "writer_name AS [Yazar Adı]," +
            "writer_surname AS [Yazar Soyadı] " +
            "FROM writer " +
            "where";



    }
}
