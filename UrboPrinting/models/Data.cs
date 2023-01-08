using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UrboPrinting
{
    public class Element
    {
        public int x { get; set; }
        public int y { get; set; }
        public int fontheight { get; set; }
        public int rotation { get; set; }
        public int fontstyle { get; set; }
        public int fontunderline { get; set; }
        public string szFaceName { get; set; }
        public string content { get; set; }
    }

    public class Tickets
    {
        public class Elements
        {
            [JsonProperty("x")]
            public int x { get; set; }

            [JsonProperty("y")]
            public int y { get; set; }

            [JsonProperty("fontheight")]
            public int fontheight { get; set; }

            [JsonProperty("rotation")]
            public int rotation { get; set; }

            [JsonProperty("fontstyle")]
            public int fontstyle { get; set; }

            [JsonProperty("fontunderline")]
            public int fontunderline { get; set; }

            [JsonProperty("szFaceName")]
            public string szFaceName { get; set; }

            [JsonProperty("content")]
            public string content { get; set; }
        }

        public class Photo
        {
            [JsonProperty("filePath")]
            public string filePath { get; set; }

            [JsonProperty("rotation")]
            public int rotation { get; set; }

            [JsonProperty("width")]
            public int width { get; set; }

            [JsonProperty("height")]
            public int height { get; set; }

            [JsonProperty("x")]
            public int x { get; set; }

            [JsonProperty("y")]
            public int y { get; set; }

        }

        public class QRCODE
        {
            [JsonProperty("data")]
            public string data { get; set; }

            [JsonProperty("encoding")]
            public int encoding { get; set; }

            [JsonProperty("rotation")]
            public int rotation { get; set; }

            [JsonProperty("exp")]
            public int exp { get; set; }

            [JsonProperty("ECLevel")]
            public int ECLevel { get; set; }

            [JsonProperty("x")]
            public int x { get; set; }

            [JsonProperty("y")]
            public int y { get; set; }
        }

        [JsonProperty("commands")]
        public string[] commands { get; set; }

        [JsonProperty("elements")]
        public Elements[] elements { get; set; }

        [JsonProperty("photos")]
        public Photo[] photos { get; set; }

        [JsonProperty("qrCode")]
        public QRCODE[] qrCode { get; set; }
    }

    public class Data
    {
        [JsonProperty("tickets")]
        public Tickets[] tickets { get; set; }

        [JsonProperty("printType")]
        public int printType { get; set; }
    }

    class Counter
    {
        private int count; // field
        public int Count   // property
        {
            get { return count; }
            set { count = value; }
        }
    }

    public class Bon
    {
        [JsonProperty("ticket")]
        public string ticket { get; set; }
    }

}
