public class ItemsCollection 
{
    private ItemType collection;

    public void AddItem(ItemType itemType)
    {
        collection |= itemType;
    }

    public void RemoveItem(ItemType itemType)
    {
        collection &= (~itemType);
    }

    public bool IsItemCollected(ItemType itemType)
    {
        return (collection & itemType) == itemType;
    }
}
