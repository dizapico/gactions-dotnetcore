using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ActionsSDK
{
    public class TableCard
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public Image image { get; set; }
        public IList<ColumnProperties> columnProperties { get; set; }
        public IList<Row> rows { get; set; }
        public IList<Button> buttons { get; set; }
    }

    public class Row
    {
        public IList<Cell> cells { get; set; }
        public bool dividerAfter { get; set; }
    }

    public class Cell
    {
        public string text { get; set; }
    }

    public class ColumnProperties
    {
        public string header { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public HorizontalAlignment hotizontalAlignment { get; set; }
    }

    public enum HorizontalAlignment
    {
        LEADING,
        CENTER,
        TRAILING
    }
}