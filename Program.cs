namespace logbug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> veges=new List<string>();
            veges.Add("CARROT");
            veges.Add("BEET");
            veges.Add("CELERY");
            veges.Add("RADDISH"); 
            veges.Add("RADISH");
            veges.Add("CABBAGE");
            Random randnum=new Random();
            int i=25;
            int[] nums = new int[i];
            for (i = 0; i < nums.Length; i++)
            { 
                nums[i] = (randnum.Next(10, 21));
                Console.Write($"{nums[i]},");
            }
            Options();
        }
        class Chosen
        {
            public int Lite;
        }
        static void Options()
        {
            
        }
    }
}