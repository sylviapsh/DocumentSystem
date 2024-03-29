using System.Collections.Generic;

public class VideoDocument : MultimediaDocument
{
    public int FrameRate { get; protected set; }
    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        base.SaveAllProperties(output);
    }
}
