using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDictionaryLibrary_Dat_Tan
{
    class Words_Management
    {
        public Word[] GetWords()
        {
            var Data = new Words_DataEntities();
            var Words = Data.Words.ToArray();
            return Words;
        }

        public Word GetWord(int id)
        {
            var Data = new Words_DataEntities();
            var Word = Data.Words.Find(id);
            return Word;
        }

        public void AddWord(string EngW, string WordType, string Meaning)
        {
            var NewWord = new Word();
            NewWord.English_Word = EngW;
            NewWord.Word_type = WordType;
            NewWord.Meaning = Meaning;

            var Data = new Words_DataEntities();
            Data.Words.Add(NewWord);
            Data.SaveChanges();
        }

        public void EditWord(int id, string EngW, string WordType, string Meaning)
        {
            var Data = new Words_DataEntities();
            var Word = Data.Words.Find(id);
            Word.English_Word = EngW;
            Word.Word_type = WordType;
            Word.Meaning = Meaning;

            Data.Entry(Word).State = System.Data.Entity.EntityState.Modified;
            Data.SaveChanges();
        }

        public void DeleteWord(int id)
        {
            var Data = new Words_DataEntities();
            Data.Words.Remove(Data.Words.Find(id));
            Data.SaveChanges();
        }
    }
}
