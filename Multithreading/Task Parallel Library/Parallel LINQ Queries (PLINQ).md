Parallel LINQ Queries (PLINQ)

Select Members of the ParallelEnumerable Class
Member Meaning in Life
AsParallel() Specifies that the rest of the query should be parallelized, if possible
WithCancellation() Specifies that PLINQ should periodically monitor the state of the provided
cancellation token and cancel execution if it is requested
WithDegreeOfParallelism() Specifies the maximum number of processors that PLINQ should use to
parallelize the query
ForAll() Enables results to be processed in parallel without first merging back to the
consumer thread, as would be the case when enumerating a LINQ result
using the foreach keyword

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
Console.WriteLine("Start any key to start processing");
Console.ReadKey();
Console.WriteLine("Processing");
Task.Factory.StartNew(ProcessIntData);
Console.ReadLine();
void ProcessIntData()
{

// Get a very large array of integers.
int[] source = Enumerable.Range(1, 10_000_000).ToArray();
// Find the numbers where num % 3 == 0 is true, returned
// in descending order.
int[] modThreeIsZero = (
from num in source
where num % 3 == 0
orderby num descending
select num).ToArray();
Console.WriteLine($"Found { modThreeIsZero.Count()} numbers that match query!");
}



AsParallel() extension method as so:
int[] modThreeIsZero = (
from num in source.AsParallel()
where num % 3 == 0
orderby num descending select num).ToArray();
Notice how the overall format of the LINQ query is identical to what you saw in previous chapters. However,
by including a call to AsParallel(), the TPL will attempt to pass the workload off to any available CPU

