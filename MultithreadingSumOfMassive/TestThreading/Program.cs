Thread[] threads = new Thread[10];
int[] array = GenerateMassive();
int tenMillion = (int)Math.Pow(10, 7);
ulong sum = 0;

GetSumOfOneThread(0, array, tenMillion, sum);

static void StartThreads(Thread[] threads, int[] array, int tenMillion, ulong sum)
{
    for (int i = 0; i < threads.Length; i++)
    {
        threads[i] = new Thread(new ParameterizedThreadStart(GetSumOfOneThread(i, array, tenMillion, sum)));    //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        threads[i].Start();
    }
}

static void GetSumOfOneThread(int startNum, int[] array, int tenMillion, ulong sum)
{
    startNum *= tenMillion;
    for (int i = startNum; i < startNum + tenMillion; i++)
    {
        sum += (ulong)array[i];
    }

}

static int[] GenerateMassive()
{
    int[] arr = new int[(int)Math.Pow(10, 8)];

    var rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next();
    }

    return arr;
}