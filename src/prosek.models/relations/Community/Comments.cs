using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.models.relations.Community
{
    public class Attributes
    {
        public int date { get; set; }
        public string text { get; set; }
        public Votes votes { get; set; }
        public string html { get; set; }
        public List<string> tags { get; set; }
    }

    public class Author
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
        public Links links { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string id { get; set; }
        public Relationships relationships { get; set; }
        public Attributes attributes { get; set; }
        public Links links { get; set; }
    }

    public class Item
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
        public Links links { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
        public string related { get; set; }
    }

    public class Meta
    {
        public int count { get; set; }
    }

    public class Relationships
    {
        public Item item { get; set; }
        public Author author { get; set; }
    }

    public class Comments
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
        public Links links { get; set; }
    }

    public class Votes
    {
        public int positive { get; set; }
        public int abuse { get; set; }
        public int negative { get; set; }
    }

    public class Datum
    {
        public Attributes attributes { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public Links links { get; set; }
        public Relationships relationships { get; set; }
    }


}
