namespace OperatorOverloading
{
    class OverLoad
    {
        public int[] Arr = new int[5];
        public bool check = true;
        public int count = 0;

        public static OverLoad operator +(OverLoad arr1, OverLoad arr2)
        {
            OverLoad arrResult = new OverLoad();

            for (int index = 0; index < 5; index++)
            {
                arrResult.Arr[index] = arr1.Arr[index] + arr2.Arr[index];
            }

            return arrResult;
        }

        public static bool operator ==(OverLoad arr1, OverLoad arr2)
        {
            OverLoad arrResult = new OverLoad();

            for (int index = 0; index < arrResult.Arr.Length; index++)
            {
                if (arr1.Arr[index] != arr2.Arr[index]) arrResult.check = false;
            }
            return arrResult.check;
        }

        public static bool operator !=(OverLoad arr1, OverLoad arr2)
        {
            OverLoad arrResult = new OverLoad();

            for (int index = 0; index < arrResult.Arr.Length; index++)
            {
                if (arr1.Arr[index] == arr2.Arr[index]) arrResult.count++;
            }

            if (arrResult.count == arrResult.Arr.Length)
            {
                arrResult.check = false;
            }

            return arrResult.check;
        }
    }
}
