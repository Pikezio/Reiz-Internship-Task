using REIZtask2;

// Test tree
Console.WriteLine("Test tree");

Branch root = new Branch();
root.Add(new Branch().Add(new Branch()));
root.Add(new Branch().Add(new Branch().Add(new Branch().Add(new Branch().Add(new Branch())))));
root.Add(new Branch().Add(new Branch().Add(new Branch())));

Console.WriteLine(root.CalculateDepth());

// Example tree
Console.WriteLine("Example tree");

Branch root2 = new Branch();
root2.Add(new Branch().Add(new Branch()));

Branch root2lvl2 = new Branch();
root2lvl2.Add(new Branch().Add(new Branch()));

Branch root2lvl3 = new Branch();
root2lvl3.Add(new Branch().Add(new Branch()));
root2lvl3.Add(new Branch());
root2lvl2.Add(root2lvl3);

root2lvl2.Add(new Branch());

root2.Add(root2lvl2);

Console.WriteLine(root2.CalculateDepth());