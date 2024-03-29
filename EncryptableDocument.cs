public abstract class EncryptableDocument : global::BinaryDocument, IEncryptable
{
    public bool IsEncrypted {get; private set;}

    public void Encrypt()
    {
        this.IsEncrypted = true;
    }

    public void Decrypt()
    {
        this.IsEncrypted = false;
    }

    public override string ToString()
    {
        if (this.IsEncrypted)
        {
            return this.GetType().Name + "[encrypted]";
        }
        return base.ToString();
    }
}
