namespace REIZtask2
{
    class Branch
    {
        List<Branch> branches = new();

        public Branch Add(Branch branch)
        {
            branches.Add(branch);
            return this;
        }

        public void PrintChildrenCount() => Console.WriteLine("Children: " + branches.Count);

        public int CalculateDepth()
        {
            int maxDepth = 0;
            foreach (var branch in branches)
            {
                maxDepth = Math.Max(maxDepth, branch.CalculateDepth());
            }
            return maxDepth + 1;
        }
    }
}
