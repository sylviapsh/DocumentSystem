using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Document : IDocument
{
    public string Name {get; protected set;}

    public string Content {get; protected set;}
    
    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        else if (key == "content")
        {
            this.Content = value;
        }
        else
        {
            throw new ArgumentException("The property you're trying to add doesn't exist!");
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name", this.Name));
        output.Add(new KeyValuePair<string, object>("content", this.Content));
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name);
        result.Append('[');
        IList<KeyValuePair<string, object>> attributes = new List<KeyValuePair<string, object>>();
        SaveAllProperties(attributes);
        var sortedAttributes = attributes.OrderBy(item => item.Key);
        var attributesArray = sortedAttributes.ToArray();
        for (int i = 0; i < attributesArray.Length; i++)
        {
            if (attributesArray[i].Value != null)
            {
                result.Append(attributesArray[i].Key);
                result.Append('=');
                result.Append(attributesArray[i].Value);
                if (i != attributesArray.Length-1)
                {
                    result.Append(';');
                }  
            }
        }
          
        result.Append(']');
        return result.ToString();
    }
}
