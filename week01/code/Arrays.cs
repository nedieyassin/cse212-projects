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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // create an array of doubles with the specified length
        // Loop through each position in the array and set the value to be the number multiplied by the position (starting at 1)
        // return the array

        // create an array of doubles with the specified length
        var result = new double[length];

        // Loop through each position in the array and set the value to be the number multiplied by the position (starting at 1)
        for (var i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Loop 'amount' times, and in each loop do the following:
        // Get the last element of the list
        // Remove the last element from the list
        // Insert the last element at the beginning of the list


        // Loop 'amount' times, and in each loop do the following:
        for (int i = 0; i < amount; i++)
        {
            // Get the last element of the list
            int last = data[data.Count - 1];

            // Remove the last element from the list
            data.RemoveAt(data.Count - 1);

            //  Insert the last element at the beginning of the list
            data.Insert(0, last);
        }
    }
}
