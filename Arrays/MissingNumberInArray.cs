namespace Array
{
    public class MissingNumberInArray

    {
        public int[] nums { get; set; } = { 1, 2, 3, 4, 5, 6, 7, 9 };
        public MissingNumberInArray()
        {
            Console.WriteLine(this.FindMissingNumber());
        }

        public int FindMissingNumber()

        {
            int n = this.nums.Length + 1;
            int sum = (n * (n + 1)) / 2;
            int sumOfArrayElements = 0;
            foreach(int num in this.nums){
                sumOfArrayElements += num;
            }
            Console.WriteLine(sum+" " + sumOfArrayElements);
            return sum-sumOfArrayElements;
        }

    }
}