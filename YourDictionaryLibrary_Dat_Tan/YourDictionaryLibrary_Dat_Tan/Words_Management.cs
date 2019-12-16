using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDictionaryLibrary_Dat_Tan
{
    class Words_Management
    {
        private mydbWordEntities db;
        public Word[] GetWords()
        {
            db = new mydbWordEntities();
            var Words = db.Words.ToArray();
            return Words;
        }
        public Word GetWord(int id)
        {
            db = new mydbWordEntities();
            var Word = db.Words.Find(id);
            return Word;
        }
        public void AddWord(string EngW, string WordType,string phonetic, string Meaning)
        {
            var NewWord = new Word();
            NewWord.English_Word = EngW.ToLower();
            NewWord.Word_Type = WordType;
            NewWord.Phonetic = phonetic;
            NewWord.Meaning = Meaning.ToLower();

            db = new mydbWordEntities();
            db.Words.Add(NewWord);
            db.SaveChanges();
        }
        public void EditWord(int id, string EngW, string WordType,string phonetic, string Meaning)
        {
            db = new mydbWordEntities();
            var Word = db.Words.Find(id);
            Word.English_Word = EngW.ToLower();
            Word.Word_Type = WordType;
            Word.Phonetic = phonetic;
            Word.Meaning = Meaning.ToLower();

            db.Entry(Word).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteWord(int id)
        {
            db = new mydbWordEntities();
            db.Words.Remove(db.Words.Find(id));
            db.SaveChanges();
        }
        public void AddWordFromImport(string[] ArrayDataWords)
        {
            var word = new Word();
            word.English_Word = ArrayDataWords[0];
            word.Word_Type = ArrayDataWords[1];
            word.Phonetic = ArrayDataWords[2];
            word.Meaning = ArrayDataWords[3];
            
            db = new mydbWordEntities();
            db.Words.Add(word);
            db.SaveChanges();
        }

        public bool Check_Word_Exist(Word[] word, string Word_to_check)
        {
            foreach (var item in word)
            {
                var EngW = db.Words.Find(item.Id);
                if (EngW.English_Word == Word_to_check)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
