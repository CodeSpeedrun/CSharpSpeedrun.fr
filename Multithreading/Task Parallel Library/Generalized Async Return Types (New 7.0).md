Generalized Async Return Types (New 7.0)

static async ValueTask<int> ReturnAnInt()
{
await Task.Delay(1_000);
return 5;
}

