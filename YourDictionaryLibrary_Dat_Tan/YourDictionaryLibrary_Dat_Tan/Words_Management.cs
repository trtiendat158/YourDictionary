using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDictionaryLibrary_Dat_Tan
{
    class Words_Management
    {
        private Words_DataEntities db;
        public Word[] GetWords()
        {
            db = new Words_DataEntities();
            var Words = db.Words.ToArray();
            return Words;
        }
        public Word GetWord(int id)
        {
            db = new Words_DataEntities();
            var Word = db.Words.Find(id);
            return Word;
        }
        public void AddWord(string EngW, string WordType, string Meaning)
        {
            var NewWord = new Word();
            NewWord.English_Word = EngW.ToLower();
            NewWord.Word_type = WordType;
            NewWord.Meaning = Meaning.ToLower();

            db = new Words_DataEntities();
            db.Words.Add(NewWord);
            db.SaveChanges();
        }
        public void EditWord(int id, string EngW, string WordType, string Meaning)
        {
            db = new Words_DataEntities();
            var Word = db.Words.Find(id);
            Word.English_Word = EngW.ToLower();
            Word.Word_type = WordType;
            Word.Meaning = Meaning.ToLower();

            db.Entry(Word).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteWord(int id)
        {
            db = new Words_DataEntities();
            db.Words.Remove(db.Words.Find(id));
            db.SaveChanges();
        }
        public void AddWordFromImport(string[] ArrayDataWords)
        {
            var word = new Word();
            word.English_Word = ArrayDataWords[0];
            word.Word_type = ArrayDataWords[1];
            word.Meaning = ArrayDataWords[2];

            db = new Words_DataEntities();
            db.Words.Add(word);
            db.SaveChanges();
        }
    }
}
