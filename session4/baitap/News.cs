using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.session4.baitap
{
    public class News : INews
    {
        public int id;
        public string title;
        public string publishDate;
        public string author;
        public string content;
        public float averageRate;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string PublishDate
        {
            get { return publishDate; }
            set {publishDate = value; }
        }
        public string Author
        {
            get { return author; }
            set  { author = value;}
        }
        public string Content
        {
            get { return content; }
            set { content = value;  }
        }
        public float AverageRate
        {
            get { return averageRate; }
            
        }
        public News(int id, string title, string publishDate, string author, string content)
        {
            this.id = id;
            this.title = title;
            this.publishDate = publishDate;
            this.author = author;
            this.content = content;
        }

        public void DisPlay()
        {
            Console.WriteLine("tin tức:" + title + "," + publishDate + "," + author + "," + content + "," + averageRate);
        }
         int[] RateList = new int[3];
        public int this[int index]
        {
            get => RateList[index];
            set => RateList[index] = value;
        }
        public void Calculate()
        {
            averageRate = (float)RateList.Average();
          
        }

    }
}
