using System.Collections.Generic;

public class WordDocument : OfficeDocument, IEditable
{
    public int? NumberOfCharacters { get; protected set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.NumberOfCharacters = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
        base.SaveAllProperties(output);
    }

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }
}
