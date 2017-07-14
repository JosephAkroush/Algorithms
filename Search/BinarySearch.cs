static bool BinarySearch(int[] items, int key, int start, int end)
{
    if (start > end)
    {
        return false;
    }

    int mid = (start + end) / 2;

    if (items[mid] == key)
    {
        return true;
    }
    else if (items[mid] > key)
    {
        return BinarySearch(items, key, start, mid - 1);
    }
    else
    {
        return BinarySearch(items, key, mid + 1, end);
    }
}
