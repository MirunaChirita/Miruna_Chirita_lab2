﻿namespace Miruna_Chirita_lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}