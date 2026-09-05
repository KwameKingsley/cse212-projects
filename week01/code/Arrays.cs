public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // PLan:
        // 1. Create a new array of doubles with the size of 'length'
        // 2. Use a for loop to iterate from 0 to length - 1
        // 3. For each index i, calculate the multiple by multiplying 'number' with (i + 1) and assign it to the array at index i
        // 4. Store the calculated multiple in the array
        // 5. Return the filled array after the loop completes

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Paln:
        // 1. Determine the split point in the list by calculating splitIndex = data.Count - amount
        // 2. Get the slice of elements that be moved to the front using GetRange(splitIndex, amount)
        // 3. Remove the elements from the original list using RemoveRange(splitIndex, amount)
        // 4. Insert the sliced elements at the beginning of the list using InsertRange(0, slicedList)

        int splitIndex = data.Count - amount;

        List<int> rightPart = data.GetRange(splitIndex, amount);
        data.RemoveRange(splitIndex, amount);
        data.InsertRange(0, rightPart);
    }
}
