using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        [MaxLength(200)]
        public string Title
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

    }
}
