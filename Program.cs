using Dumpify;


               //Inputs 

IEnumerable<int> intcollection = [1,2,3,4,5,6,7,8,9,10];
// IEnumerable<object> collection = [1,2,"hello","welcome",3,4,5,6,"world","welcome",7,8,9,10];

// IEnumerable<object> objcollection = [1,2,3,4,5,6,7,8,9,10];



              //LINQ Queries

// collection.Dump();


// collection.Where(x=>x>2).Dump(); // .Where()


// collection.OfType<int>().Dump(); // .OfType()
// collection.OfType<string>().Dump(); // .OfType()


// collection.Skip(2).Dump(); //.Skip()
// collection.Take(4).Dump(); //.Take()


// collection.SkipLast(2).Dump(); //.SkipLast()
// collection.TakeLast(4).Dump(); //.TakeLast()


// collection.SkipWhile(x=>x<5).Dump(); //.SkipWhile()
// collection.TakeWhile(x=>x<5).Dump(); //.TakeWhile()


// collection.Select(x=>x*2).Dump(); //.Select()
// collection.Select(x=>x.ToString()).Dump(); //.Select()
// collection.Select((x,i)=> $"{i}: {x}").Dump(); // .Select() with index


// collection.SelectMany(x=>new [] {x*2}).Dump(); // .SelectMany()
// collection.SelectMany(x=> new [] {x.ToString()}).Dump(); // .SelectMany() with string conversion
// collection.SelectMany(x => new[] { x }.Select(v => v.ToString())).Dump(); // .SelectMany() with nested select


// objcollection.Cast<int>().Dump(); // .Cast<int>()


// intcollection.Chunk(4).Dump(); // .Chunk()

