
public class ArrayDuplcateCheck
{
    public static string execute()
    {

        int[] integers = [1, 1, 2, 3, 3];
        List<int> duplicates = new List<int>();

        for (int i = 0; i < integers.Length; i++)
        {
            int item = integers[i];
            int index = Array.IndexOf(integers, item);

            for (int j = 0; j < integers.Length; j++)
            {
                int secitem = integers[j];
                int addedtoDuplicate = duplicates.IndexOf(secitem);

                if (addedtoDuplicate == -1)
                {
                    if (item == secitem && index != j)
                    {
                        // Console.WriteLine("Duplicate item " + secitem);
                        int checkItemsInDuplicate = duplicates.IndexOf(item);
                        Console.WriteLine(checkItemsInDuplicate);
                        if (checkItemsInDuplicate == -1)
                        {
                            duplicates.Add(secitem);
                        }

                    }
                }
            }
        }

        string returnDuplicates = string.Join(",", duplicates);
        return returnDuplicates;
    }
}