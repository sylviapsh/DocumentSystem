using System.Collections.Generic;

public class PdfDocument : EncryptableDocument
{
    public int NumberOfPages { get; protected set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.NumberOfPages = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        base.SaveAllProperties(output);
    }
}
