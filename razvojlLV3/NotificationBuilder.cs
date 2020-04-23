using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojlLV3
{
    class NotificationBuilder : IBuilder
    {   
        private string author = "";
        private string text = "";
        private string title = "";
        private ConsoleColor consoleColor = ConsoleColor.Black;
        private Category level = Category.INFO;
        private DateTime time = DateTime.Now;
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author,title,text,time,level,consoleColor);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.consoleColor = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.time = time;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }
    }
}
