using FlowDocs.Core;
using FlowDocs.Data;
using System;
using Microsoft.EntityFrameworkCore.Design;

namespace FlowDocs.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = Settings.Get();

            var db = new FlowDocsDbContext(settings);

            db.Database.EnsureCreated();
        }
    }
}
