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
        // Step 1: Create an array to hold 'count' elements
        double[] result = new double[length];
        
        // Step 2: Use a loop to populate the array with multiples of 'start'
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        
        // Step 3: Return the array
        return result;
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
        // Step 1: Determine the actual rotation amount using modulo
        int shift = amount % data.Count;
        if (shift == 0) return; // No rotation needed
        
        // Step 2: Use list slicing to separate the last 'shift' elements and the rest
        List<int> tail = data.GetRange(data.Count - shift, shift);
        List<int> head = data.GetRange(0, data.Count - shift);
        
        // Step 3: Clear original list and rebuild it with rotated values
        data.Clear();
        data.AddRange(tail); // Add the last 'shift' elements to the front
        data.AddRange(head); // Append the remaining elements
    }
}
