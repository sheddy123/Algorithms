namespace Codilityy
{
    public class BulbSwitcher
    {
        public int soution(int[] A)
        {
            //Declare variables

            //This will hold the maximum value of the rightmost bulb at the
            //current state of iteration
            int successiveBulb = -1; 
            //This will hold the number of moments for which every turned on
            //bulb shines
            int momentsCount = 0;
            //This is the counter variable used in the loop
            int i = 0;
            
            while (i < A.Length)
            {
                //SuccessiveBulb gets the current value if the current value is
                //greater than the succesive bulbs value
                if(A[i] > successiveBulb)
                    successiveBulb = A[i];
                
                //If the value of successive bulb is equal to the index, that means there exist
                //a moment for which the bulb will shine which implies that previous bulbs are
                //also switched on as well except when it is the first.
                if(successiveBulb == i + 1)
                    momentsCount++;
                
                i++;
            }

            return momentsCount;
        }
    }

}
