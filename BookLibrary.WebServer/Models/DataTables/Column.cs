﻿namespace BookLibrary.WebServer.Models.DataTables
{
    public class Column
    {
        public int Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public Search Search { get; set; }
    }
}
