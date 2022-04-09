using CreationalPatterns;
// See https://aka.ms/new-console-template for more information
Task task1 = Task.Factory.StartNew(()=>{
    Counter counter1 = Counter.GetInstance();
    counter1.AddOne();
    Console.WriteLine("Count1:"+counter1.count.ToString());
});
Task task2 = Task.Factory.StartNew(()=>{
    Counter counter2 = Counter.GetInstance();
    counter2.AddOne();
    Console.WriteLine("Count2:"+counter2.count.ToString());
});
Task.WaitAll(task1,task2);
