using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojlLV3
{
    class Director
    {
        public ConsoleNotification INFOnotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("title");
            builder.SetLevel(Category.INFO);
            builder.SetColor(ConsoleColor.White);
            builder.SetText("TEXT");
            return builder.Build();
        }
        public ConsoleNotification ERRORnotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("title");
            builder.SetLevel(Category.ERROR);
            builder.SetColor(ConsoleColor.Red);
            builder.SetText("TEXT");
            return builder.Build();
        }
        public ConsoleNotification ALERTnotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("title");
            builder.SetLevel(Category.ALERT);
            builder.SetColor(ConsoleColor.DarkRed);
            builder.SetText("TEXT");
            return builder.Build();
        }
    }
}
